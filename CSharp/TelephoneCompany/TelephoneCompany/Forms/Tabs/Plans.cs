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
    public partial class Plans : UserControl
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
        public Plans()
        {
            InitializeComponent();
        }
        public void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "Название тарифа");
            dataGridView1.Columns.Add("Cost", "Цена тарифа");
            dataGridView1.Columns.Add("InternetCount", "Количество ГБ");
            dataGridView1.Columns.Add("MinutesCount", "Количество Минут");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetValue(2), record.GetInt32(3), record.GetInt32(4), RowState.ModifiedNew);
        }

        public void RefreshDataGrid(DataGridView dgw)
        {
            dataGridView1.Rows.Clear();

            string querystring = $"select * from Plans";

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
                textBox_cost.Text = row.Cells[2].Value.ToString();
                textBox_gigi.Text = row.Cells[3].Value.ToString();
                textBox_minutes.Text = row.Cells[4].Value.ToString();
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
                    var deleteQuery = $"delete from Plans where id = {id}";
                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var cost = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var gigi = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var minutes = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update Plans set Name = '{name}', Cost = '{cost}', InternetCount = '{gigi}', MinutesCount = '{minutes}' where id = '{id}'";
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
            var cost = textBox_cost.Text;
            int gigi;
            int minutes;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_gigi.Text, out gigi) && int.TryParse(textBox_minutes.Text, out minutes))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, name, cost, gigi, minutes);
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Количество ГБ и мин. должно быть только из цифр!");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
        private void new_btn_Click(object sender, EventArgs e)
        {
            Add_Plans add_Plans = new Add_Plans();
            add_Plans.Show();
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
