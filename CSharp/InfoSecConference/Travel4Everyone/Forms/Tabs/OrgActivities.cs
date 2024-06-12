using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace Travel4Everyone.UserControls
{
    public partial class OrgActivities : UserControl
    {
        private readonly DataBase database = new DataBase();
        public OrgActivities()
        {
            InitializeComponent();
        }
        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            _ = dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetDateTime(3), record.GetInt32(4), record.GetString(5), record.GetInt32(6), record.GetValue(7), record.GetString(8), record.GetString(9), record.GetString(10), record.GetString(11), record.GetString(12), record.GetString(13), record.GetString(14));
            dgw.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd";
        }
        public void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querystring = $"select * from Activities";
            MySqlCommand command = new MySqlCommand(querystring, database.GetConnection());
            database.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            database.CloseConnection();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int selectedID = (int)dataGridView1.Rows[selectedRowIndex].Cells[0].Value;

                // Подтверждение удаления
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteRow(selectedID);
                    RefreshDataGrid(dataGridView1);
                }
            }
            else
            {
                _ = MessageBox.Show("Выберите запись для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DeleteRow(int id)
        {
            string deleteQuery = "DELETE FROM Activities WHERE ID = @ID";

            using (MySqlCommand command = new MySqlCommand(deleteQuery, database.GetConnection()))
            {
                _ = command.Parameters.AddWithValue("@ID", id);

                try
                {
                    database.OpenConnection();
                    _ = command.ExecuteNonQuery();
                    _ = MessageBox.Show("Запись удалена успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show($"Ошибка удаления записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    database.CloseConnection();
                }
            }
        }
    }
}