using MySqlConnector;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Travel4Everyone.UserControls
{
    public partial class JuryProfile : UserControl
    {
        private readonly DataBase database = new DataBase();
        private readonly string juryFullName; // FullName текущего жюри

        public JuryProfile(string juryFullName)
        {
            InitializeComponent();
            this.juryFullName = juryFullName;
            SetGreeting(GreetingsLabel);
            LoadJuryData();
        }

        private void LoadJuryData()
        {
            string query = "SELECT ID, FullName, Gender, Email, DateOfBirth, CountryCode, PhoneNumber, Direction, Password, Photo FROM Jury WHERE FullName = @JuryFullName";

            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                _ = command.Parameters.AddWithValue("@JuryFullName", juryFullName);
                database.OpenConnection();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Заполните текстовые поля
                        txtID.Text = reader["ID"].ToString();
                        txtFullName.Text = reader["FullName"].ToString();
                        txtGender.Text = reader["Gender"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtDateOfBirth.Text = reader["DateOfBirth"].ToString();
                        txtCountryCode.Text = reader["CountryCode"].ToString();
                        txtPhoneNumber.Text = reader["PhoneNumber"].ToString();
                        txtDirection.Text = reader["Direction"].ToString();
                        txtPassword.Text = reader["Password"].ToString();

                        // Загрузите изображение
                        byte[] photoData = DBNull.Value.Equals(reader["Photo"]) ? null : (byte[])reader["Photo"];
                        pictureBoxPhoto.Image = ByteArrayToImage(photoData);
                    }
                }

                database.CloseConnection();
            }
        }

        private void SetGreeting(Label label)
        {
            DateTime now = DateTime.Now;
            int hour = now.Hour;

            label.Text = hour >= 9 && hour <= 11 ? "Доброе утро!" : hour >= 12 && hour <= 18 ? "Добрый день!" : "Добрый вечер!";
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null)
            {
                // Если массив байтов равен null, вернуть null или другое значение по умолчанию
                return null; // или возвратить другое изображение по умолчанию
            }

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            ChangePhoto();
        }

        private void SaveChanges()
        {
            string updateQuery = @"UPDATE Jury SET Gender = @Gender, Email = @Email, DateOfBirth = @DateOfBirth, CountryCode = @CountryCode, PhoneNumber = @PhoneNumber, Direction = @Direction, Password = @Password WHERE FullName = @JuryFullName";

            using (MySqlCommand command = new MySqlCommand(updateQuery, database.GetConnection()))
            {
                _ = command.Parameters.AddWithValue("@Gender", txtGender.Text);
                _ = command.Parameters.AddWithValue("@Email", txtEmail.Text);
                _ = command.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(txtDateOfBirth.Text));
                _ = command.Parameters.AddWithValue("@CountryCode", txtCountryCode.Text);
                _ = command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                _ = command.Parameters.AddWithValue("@Direction", txtDirection.Text);
                _ = command.Parameters.AddWithValue("@Password", txtPassword.Text);
                _ = command.Parameters.AddWithValue("@JuryFullName", juryFullName);

                database.OpenConnection();
                _ = command.ExecuteNonQuery();
                database.CloseConnection();
            }

            _ = MessageBox.Show("Изменения сохранены успешно!");
        }

        private void ChangePhoto()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                openFileDialog.Title = "Выберите изображение";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Загрузите новое изображение из файла
                    string filePath = openFileDialog.FileName;
                    Image newImage = Image.FromFile(filePath);

                    // Отобразите новое изображение на форме
                    pictureBoxPhoto.Image = newImage;

                    // Преобразуйте изображение в массив байтов
                    byte[] newImageBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        newImage.Save(ms, newImage.RawFormat);
                        newImageBytes = ms.ToArray();
                    }

                    // Сохраните новое изображение в базе данных
                    string updatePhotoQuery = "UPDATE Jury SET Photo = @Photo WHERE FullName = @JuryFullName";
                    using (MySqlCommand command = new MySqlCommand(updatePhotoQuery, database.GetConnection()))
                    {
                        _ = command.Parameters.AddWithValue("@Photo", newImageBytes);
                        _ = command.Parameters.AddWithValue("@JuryFullName", juryFullName);

                        database.OpenConnection();
                        _ = command.ExecuteNonQuery();
                        database.CloseConnection();
                    }

                    _ = MessageBox.Show("Изображение изменено успешно!");
                }
            }
        }
        private void TogglePasswordVisibility()
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                guna2PictureBox1.Image = Properties.Resources.visible_pass;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                guna2PictureBox1.Image = Properties.Resources.invisible_pass;
            }
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }
    }
}
