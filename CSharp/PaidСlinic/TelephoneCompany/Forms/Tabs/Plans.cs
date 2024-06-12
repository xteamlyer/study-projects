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
            dataGridView1.Columns.Add("[Код специальности]", "Код специальности");
            dataGridView1.Columns.Add("[Наименования специальности]", "Наименования специальности");
        }

        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt64(0), record.GetString(1));
        }

        public void RefreshDataGrid(DataGridView dgw)
        {
            dataGridView1.Rows.Clear();

            string querystring = $"select * from [Специальность]";

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
        private void new_btn_Click(object sender, EventArgs e)
        {
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            UpdateRow();
        }
    }
}
