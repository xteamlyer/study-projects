using MySqlConnector;
using System;
using System.Data;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Travel4Everyone
{
    public partial class Register : Form
    {
        private readonly DataBase _database = new DataBase();
        private readonly ToolTip _tooltip = new ToolTip();

        public Register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            CheckConnections();
        }

        private void RegisterBtn_click(object sender, EventArgs e)
        {
            CheckConnections();

            string fullname = txtFullName.Text;
            string gender = txtGender.Text;
            string email = txtEmail.Text;
            string dateofbirth = guna2DateTimePicker1.Text;
            string countrycode = txtCountryCode.Text;
            string phonenumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(fullname) || string.IsNullOrWhiteSpace(gender) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(dateofbirth) || string.IsNullOrWhiteSpace(countrycode) || string.IsNullOrWhiteSpace(phonenumber) || string.IsNullOrWhiteSpace(password))
            {
                _ = MessageBox.Show("Значения не должны быть пустыми!", "Введите значения!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(password, "^[A-Za-z0-9!?]+$"))
            {
                _tooltip.Show("Пароль может содержать только буквы и цифры и знак вопроса/восклицания.", txtPassword);
                return;
            }

            if (!IsValidEmail(email))
            {
                _ = MessageBox.Show("Неправильный формат почты!", "Введите правильный E-mail!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckIfUserExists(email, password))
            {
                _ = MessageBox.Show("Пользователь уже зарегистрирован");
                return;
            }

            try
            {
                AddUserToDatabase(password, email);
                _ = MessageBox.Show("Аккаунт зарегистрирован", "Успешно");

                Login frm_login = new Login();
                Hide();
                _ = frm_login.ShowDialog();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ошибка: {ex.Message}");
            }
            finally
            {
                _database.CloseConnection();
            }
        }

        private void ExitPicture_click(object sender, EventArgs e)
        {
            Login frm_login = new Login();
            Close();
            frm_login.Show();
        }

        private bool CheckIfUserExists(string email, string password)
        {
            using (MySqlDataAdapter adapter = new MySqlDataAdapter())
            {
                DataTable table = new DataTable();

                string querystring = $"SELECT * FROM Participants WHERE Email = @email AND Password = @Password";
                MySqlCommand command = new MySqlCommand(querystring, _database.GetConnection());
                _ = command.Parameters.AddWithValue("@email", email);
                _ = command.Parameters.AddWithValue("@Password", password);

                adapter.SelectCommand = command;
                _ = adapter.Fill(table);

                return table.Rows.Count > 0;
            }
        }

        private void AddUserToDatabase(string password, string email)
        {
            string querystring = "INSERT INTO Participants(FullName, Gender, Email, DateOfBirth, CountryCode, PhoneNumber, Password) VALUES(@fullname, @gender, @email, @dateofbirth, @countrycode, @phonenumber, @password)";
            using (MySqlCommand command = new MySqlCommand(querystring, _database.GetConnection()))
            {
                _ = command.Parameters.AddWithValue("@fullname", txtFullName.Text);
                _ = command.Parameters.AddWithValue("@gender", txtGender.Text);
                _ = command.Parameters.AddWithValue("@email", email);
                _ = command.Parameters.AddWithValue("@dateofbirth", guna2DateTimePicker1.Text);
                _ = command.Parameters.AddWithValue("@countrycode", txtCountryCode.Text);
                _ = command.Parameters.AddWithValue("@phonenumber", txtPhoneNumber.Text);
                _ = command.Parameters.AddWithValue("@password", password);

                _database.OpenConnection();
                _ = command.ExecuteNonQuery();
                _database.CloseConnection();
            }
        }

        private bool CheckInternetConnection()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    _ = client.OpenRead("https://www.google.com");
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void CheckConnections()
        {
            if (!CheckInternetConnection())
            {
                _ = MessageBox.Show("Отсутствует подключение к Интернету.");
                Application.Exit();
            }
        }

        private void TogglePasswordVisibility()
        {
            txtPassword.PasswordChar = (txtPassword.PasswordChar == '*') ? '\0' : '*';
            guna2PictureBox1.Image = (txtPassword.PasswordChar == '*') ? Properties.Resources.invisible_pass : Properties.Resources.visible_pass;
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
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

        private void TogglePasswordVisibilityPic_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }
    }
}
