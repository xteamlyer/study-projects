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

namespace TelephoneCompany.UserControls
{
    public partial class Calls : UserControl
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
        public Calls()
        {
            InitializeComponent();
        }
        public void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("ClientID", "ID клиента");
            dataGridView1.Columns.Add("CallStart", "Начало звонка");
            dataGridView1.Columns.Add("CallEnd", "Конец звока");
            dataGridView1.Columns.Add("PhoneNumber", "Телефонный номер звонка");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }
        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetDateTime(2), record.GetDateTime(3), record.GetInt64(4), RowState.ModifiedNew);
        }

        public void RefreshDataGrid(DataGridView dgw)
        {
            dataGridView1.Rows.Clear();

            string querystring = $"select * from CallHistory";

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
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_clientid.Text = row.Cells[1].Value.ToString();
                textBox_callstart.Text = row.Cells[2].Value.ToString();
                textBox_callend.Text = row.Cells[3].Value.ToString();
                textBox_number.Text = row.Cells[4].Value.ToString();
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
            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;
                if(rowState == RowState.Existed)
                {
                    continue;
                }
                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from CallHistory where id = {id}";
                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }
                if(rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var clientid = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var callstart = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var callend = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var number = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update CallHistory set ClientID = '{clientid}', CallStart = '{callstart}', CallEnd = '{callend}', PhoneNumber = '{number}' where id = '{id}'";
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
            var clientid = textBox_clientid.Text;
            var callstart = textBox_callstart.Text;
            var callend = textBox_callend.Text;
            Int64 number;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (Int64.TryParse(textBox_number.Text, out number))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, clientid, callstart, callend, number);
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Номер должен быть только из цифр!");
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            Add_Calls addCalls = new Add_Calls();
            addCalls.Show();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            UpdateRow();
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
           ChangeRows();
        }
    }
}
