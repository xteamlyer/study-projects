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
            dataGridView1.Columns.Add("[Код врача]", "Код врача");
            dataGridView1.Columns.Add("Фамилия", "Фамилия");
            dataGridView1.Columns.Add("Имя", "Имя");
            dataGridView1.Columns.Add("Отчество", "Отчество");
            dataGridView1.Columns.Add("[Код специальности]", "Код специальности");
            dataGridView1.Columns.Add("[Код уровня квалификации]", "Код уровня квалификации");
        }
        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt64(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt64(4), record.GetInt64(5));
        }

        public void RefreshDataGrid(DataGridView dgw)
        {
            dataGridView1.Rows.Clear();

            string querystring = $"select * from [Врач]";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }


        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
            }
        }
        public void deleteRow()
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

        public void UpdateRow()
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

        public void new_btn_Click(object sender, EventArgs e)
        {
            Add_Calls addCalls = new Add_Calls();
            addCalls.Show();
        }

        public void del_btn_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        public void save_btn_Click(object sender, EventArgs e)
        {
            UpdateRow();
        }

        public void change_btn_Click(object sender, EventArgs e)
        {
        }
    }
}
