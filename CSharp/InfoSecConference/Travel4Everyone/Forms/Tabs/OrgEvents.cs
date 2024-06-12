using MySqlConnector;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Travel4Everyone.Forms.Adds;

namespace Travel4Everyone.UserControls
{
    public partial class OrgEvents : UserControl
    {
        private readonly DataBase database = new DataBase();
        public OrgEvents()
        {
            InitializeComponent();
        }

        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            byte[] imageData = DBNull.Value.Equals(record[1]) ? null : (byte[])record[1];
            Image image = ByteArrayToImage(imageData);

            _ = dgw.Rows.Add(record.GetInt32(0), image, record.GetString(2), record.GetDateTime(3), record.GetInt32(4), record.GetString(5));
            dgw.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd";
        }

        public void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querystring = "SELECT E.ID, E.Image, E.EventName, E.EventDate, E.Duration, C.Name FROM Events E JOIN Cities C ON E.CityID = C.ID;";  // Замени на свой запрос
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

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0)
            {
                return null;
            }

            ImageConverter converter = new ImageConverter();
            Image image = (Image)converter.ConvertFrom(byteArrayIn);

            return image;
        }
        private void RefreshPic_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
        private void NewBtn_Click(object sender, EventArgs e)
        {
            AddJury addJury = new AddJury();
            addJury.Show();
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
            string deleteQuery = "DELETE FROM Events WHERE ID = @ID";

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