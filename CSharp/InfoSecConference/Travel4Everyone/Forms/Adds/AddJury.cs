using MySqlConnector;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Travel4Everyone.Forms.Adds
{
    public partial class AddJury : Form
    {
        private readonly DataBase database = new DataBase();
        private byte[] selectedImageBytes; // Байты выбранного изображения

        public AddJury()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_click(object sender, EventArgs e)
        {
            database.OpenConnection();
            string fullname = txtFullName.Text;
            string gender = txtGender.Text;
            string email = txtEmail.Text;
            string dateofbirth = guna2DateTimePicker1.Text;
            string countrycode = txtCountryCode.Text;
            string phonenumber = txtPhoneNumber.Text;
            string direction = txtDirection.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(dateofbirth) || string.IsNullOrEmpty(countrycode) || string.IsNullOrEmpty(phonenumber) || string.IsNullOrEmpty(dateofbirth) || string.IsNullOrEmpty(direction) || string.IsNullOrEmpty(password))
            {
                _ = MessageBox.Show("Значения не должны быть пустыми!", "Введите значения!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                _ = MessageBox.Show("Неправильный формат почты!", "Введите правильный E-mail!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidPhoneNumber(phonenumber))
            {
                _ = MessageBox.Show("Неправильный формат номера телефона!", "Введите правильный номер телефона!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Добавление изображения (если выбрано)
            string addQuery = selectedImageBytes != null
                ? "INSERT INTO Jury(FullName, Gender, Email, DateOfBirth, CountryCode, PhoneNumber, Direction, Password, Photo) VALUES (@fullname, @gender, @email, @dateofbirth, @countrycode, @phonenumber, @direction, @password, @photo)"
                : "INSERT INTO Jury(FullName, Gender, Email, DateOfBirth, CountryCode, PhoneNumber, Direction, Password) VALUES (@fullname, @gender, @email, @dateofbirth, @countrycode, @phonenumber, @direction, @password)";
            using (MySqlCommand command = new MySqlCommand(addQuery, database.GetConnection()))
            {
                _ = command.Parameters.AddWithValue("@fullname", fullname);
                _ = command.Parameters.AddWithValue("@gender", gender);
                _ = command.Parameters.AddWithValue("@email", email);
                _ = command.Parameters.AddWithValue("@dateofbirth", dateofbirth);
                _ = command.Parameters.AddWithValue("@countrycode", countrycode);
                _ = command.Parameters.AddWithValue("@phonenumber", phonenumber);
                _ = command.Parameters.AddWithValue("@direction", direction);
                _ = command.Parameters.AddWithValue("@password", password);

                if (selectedImageBytes != null)
                {
                    _ = command.Parameters.AddWithValue("@photo", selectedImageBytes);
                }

                _ = command.ExecuteNonQuery();
            }

            _ = MessageBox.Show("Запись создана!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            database.CloseConnection();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                openFileDialog.Title = "Выберите изображение";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Image selectedImage = Image.FromFile(filePath);

                    // Преобразование изображения в массив байтов
                    using (MemoryStream ms = new MemoryStream())
                    {
                        selectedImage.Save(ms, selectedImage.RawFormat);
                        selectedImageBytes = ms.ToArray();
                    }

                    // Отображение предпросмотра изображения в pictureBoxPhoto
                    pictureBoxPhoto.Image = selectedImage;
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            try
            {
                _ = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return false;
            }
            string regexPattern = @"^\+[1-9]{1}[0-9]{3,14}$";
            return Regex.IsMatch(phoneNumber, regexPattern);
        }
    }
}