using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelephoneCompany.Forms.Adds;

namespace TelephoneCompany.UserControls
{
    public partial class Clients : UserControl
    {
        enum RowState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }

        DataBase database = new DataBase();
        int selectedRow;
        public Clients()
        {
            InitializeComponent();
        }
        public void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("FullName", "Имя клиента");
            dataGridView1.Columns.Add("Address", "Адрес проживания");
            dataGridView1.Columns.Add("PhoneNumber", "Номер");
            dataGridView1.Columns.Add("PlanID", "ID Тарифного плана");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt64(3), record.GetInt32(4), RowState.ModifiedNew);
        }

        public void RefreshDataGrid(DataGridView dgw)
        {
            dataGridView1.Rows.Clear();

            string querystring = $"select * from Clients";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_name.Text = row.Cells[1].Value.ToString();
                textBox_address.Text = row.Cells[2].Value.ToString();
                textBox_number.Text = row.Cells[3].Value.ToString();
                textBox_planid.Text = row.Cells[4].Value.ToString();
            }
        }
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        private void UpdateRow()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;
                if (rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Clients where id = {id}";
                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var address = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var number = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var planid = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update Clients set FullName = '{name}', Address = '{address}', PhoneNumber = '{number}', PlanID = '{planid}' where id = '{id}'";
                    var command = new SqlCommand(changeQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void ChangeRows()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = textBox_id.Text;
            var name = textBox_name.Text;
            var address = textBox_address.Text;
            Int64 number;
            int planid;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (Int64.TryParse(textBox_planid.Text, out number) && int.TryParse(textBox_planid.Text, out planid))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, name, address, number, planid);
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Номер и ID тарифа должны быть только из цифр!");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            Add_Clients addclients = new Add_Clients();
            addclients.Show();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            ChangeRows();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            UpdateRow();
        }
    }
}
