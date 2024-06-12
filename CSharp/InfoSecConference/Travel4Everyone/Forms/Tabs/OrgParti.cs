using MySqlConnector;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Travel4Everyone.Forms.Adds;

namespace Travel4Everyone.UserControls
{
    public partial class OrgParti : UserControl
    {
        private readonly DataBase database = new DataBase();
        public OrgParti()
        {
            InitializeComponent();
        }
        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            byte[] imageData = DBNull.Value.Equals(record[8]) ? null : (byte[])record[8];
            Image image = ByteArrayToImage(imageData);

            _ = dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDateTime(4), record.GetString(5), record.GetString(6), record.GetString(7), image);
            dgw.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";
        }

        public void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querystring = "SELECT ID, FullName, Gender, Email, DateOfBirth, CountryCode, PhoneNumber, Password, Photo FROM Participants";

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
            AddParti addParti = new AddParti();
            addParti.Show();
        }
        private void DelBtn_Click(object sender, EventArgs e)
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
            string deleteQuery = "DELETE FROM Participants WHERE ID = @ID";

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
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Проверяем, что мы в нужном столбце (например, столбец с изображениями)
            if (e.ColumnIndex == 9)
            {
                // Устанавливаем максимальную высоту
                int maxHeight = 100; // Замените на ваше значение

                // Проверяем, что значение в ячейке - это изображение
                if (e.Value is Image image)
                {
                    // Рассчитываем новый размер с учетом максимальной высоты
                    int newHeight = Math.Min(image.Height, maxHeight);
                    int newWidth = (int)(image.Width * ((double)newHeight / image.Height));

                    // Устанавливаем новый размер для отображения в ячейке
                    e.Value = new Bitmap(image, newWidth, newHeight);
                }
            }
        }
    }
}