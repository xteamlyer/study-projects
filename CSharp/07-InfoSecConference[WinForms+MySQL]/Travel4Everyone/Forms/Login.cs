using Guna.UI2.WinForms;
using MySqlConnector;
using System;
using System.Data;
using System.Net;
using System.Security;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Travel4Everyone
{
    public partial class Login : Form
    {
        private readonly DataBase _database = new DataBase();
        private readonly ToolTip _tooltip = new ToolTip();

        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CheckConnections();
            LoadUserSettings();
            _tooltip.SetToolTip(login_textbox, "Введите ваш email");
            _tooltip.SetToolTip(password_textbox, "Введите ваш пароль");
        }

        public void Login_button_Click(object sender, EventArgs e)
        {
            string email = login_textbox.Text.Trim();
            SecureString password = password_textbox.GetSecureText().Copy();
            CheckConnections();

            if (string.IsNullOrEmpty(email) || password.Length == 0)
            {
                _ = MessageBox.Show("Пароль и email не должны быть пустыми!", "Введите значения!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(email, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"))
            {
                _tooltip.Show("Пожалуйста, введите действительный адрес электронной почты.", login_textbox);
                return;
            }

            if (string.IsNullOrEmpty(captcha_textbox.Text) || captcha_textbox.Text.Trim() != "5")
            {
                _ = MessageBox.Show("Неверный ответ на капчу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Проверяем наличие соответствующей комбинации email и пароля в таблице жюри
                MySqlCommand juryCommand = new MySqlCommand("SELECT * FROM Jury WHERE Email = @Email AND Password = @Password", _database.GetConnection());
                _ = juryCommand.Parameters.AddWithValue("@Email", email);
                _ = juryCommand.Parameters.AddWithValue("@Password", ConvertToUnsecureString(password));

                // Проверяем наличие соответствующей комбинации email и пароля в таблице участников
                MySqlCommand participantCommand = new MySqlCommand("SELECT * FROM Participants WHERE Email = @Email AND Password = @Password", _database.GetConnection());
                _ = participantCommand.Parameters.AddWithValue("@Email", email);
                _ = participantCommand.Parameters.AddWithValue("@Password", ConvertToUnsecureString(password));

                // Проверяем наличие соответствующей комбинации email и пароля в таблице жюри
                MySqlCommand moderCommand = new MySqlCommand("SELECT * FROM Moderators WHERE Email = @Email AND Password = @Password", _database.GetConnection());
                _ = moderCommand.Parameters.AddWithValue("@Email", email);
                _ = moderCommand.Parameters.AddWithValue("@Password", ConvertToUnsecureString(password));

                // Проверяем наличие соответствующей комбинации email и пароля в таблице участников
                MySqlCommand organizersCommand = new MySqlCommand("SELECT * FROM Organizers WHERE Email = @Email AND Password = @Password", _database.GetConnection());
                _ = organizersCommand.Parameters.AddWithValue("@Email", email);
                _ = organizersCommand.Parameters.AddWithValue("@Password", ConvertToUnsecureString(password));

                _database.OpenConnection();

                DataTable juryTable = new DataTable();
                DataTable participantTable = new DataTable();
                DataTable moderTable = new DataTable();
                DataTable organizersTable = new DataTable();


                using (MySqlDataAdapter juryAdapter = new MySqlDataAdapter(juryCommand))
                {
                    _ = juryAdapter.Fill(juryTable);
                }
                using (MySqlDataAdapter participantAdapter = new MySqlDataAdapter(participantCommand))
                {
                    _ = participantAdapter.Fill(participantTable);
                }
                using (MySqlDataAdapter moderAdapter = new MySqlDataAdapter(moderCommand))
                {
                    _ = moderAdapter.Fill(moderTable);
                }
                using (MySqlDataAdapter organizersAdapter = new MySqlDataAdapter(organizersCommand))
                {
                    _ = organizersAdapter.Fill(organizersTable);
                }

                if (juryTable.Rows.Count > 0)
                {
                    // Переход на форму жюри
                    string fullName = GetFullNameFromDatabase(email, "Jury");
                    _ = MessageBox.Show($"Вы успешно вошли как жюри: {fullName}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    JuryForm juryForm = new JuryForm();
                    juryForm.label1.Text = fullName;
                    SetGreeting(juryForm.label3);
                    juryForm.Show();
                    Hide();

                    if (rememberMeCheckbox.Checked)
                    {
                        SaveUserSettings(email, ConvertToUnsecureString(password));
                    }
                }
                else if (participantTable.Rows.Count > 0)
                {
                    // Переход на форму участника
                    string fullName = GetFullNameFromDatabase(email, "Participants");
                    _ = MessageBox.Show($"Вы успешно вошли как участник: {fullName}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PartiForm participantForm = new PartiForm();
                    participantForm.label1.Text = fullName;
                    SetGreeting(participantForm.label3);
                    participantForm.Show();
                    Hide();

                    if (rememberMeCheckbox.Checked)
                    {
                        SaveUserSettings(email, ConvertToUnsecureString(password));
                    }
                }
                else if (moderTable.Rows.Count > 0)
                {
                    // Переход на форму модератора
                    string fullName = GetFullNameFromDatabase(email, "Moderators");
                    _ = MessageBox.Show($"Вы успешно вошли как модератор: {fullName}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ModeratorsForm moderatorsForm = new ModeratorsForm();
                    moderatorsForm.label1.Text = fullName;
                    SetGreeting(moderatorsForm.label3);
                    moderatorsForm.Show();
                    Hide();

                    if (rememberMeCheckbox.Checked)
                    {
                        SaveUserSettings(email, ConvertToUnsecureString(password));
                    }
                }
                else if (organizersTable.Rows.Count > 0)
                {
                    // Переход на форму организатора
                    string fullName = GetFullNameFromDatabase(email, "Organizers");
                    _ = MessageBox.Show($"Вы успешно вошли как организатор: {fullName}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OrganizersForm organizersForm = new OrganizersForm();
                    organizersForm.label1.Text = fullName;
                    SetGreeting(organizersForm.label3);
                    organizersForm.Show();
                    Hide();

                    if (rememberMeCheckbox.Checked)
                    {
                        SaveUserSettings(email, ConvertToUnsecureString(password));
                    }
                }
                else
                {
                    _ = MessageBox.Show("Неверный email или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _database.CloseConnection();
            }
        }
        private void SaveUserSettings(string email, string password)
        {
            Properties.Settings.Default.UserLogin = email;
            Properties.Settings.Default.UserPassword = password;
            Properties.Settings.Default.RememberMe = true;
            Properties.Settings.Default.Save();
        }

        private void ClearUserSettings()
        {
            Properties.Settings.Default.UserLogin = "";
            Properties.Settings.Default.UserPassword = "";
            Properties.Settings.Default.RememberMe = false;
            Properties.Settings.Default.Save();
        }

        private void LoadUserSettings()
        {
            rememberMeCheckbox.Checked = Properties.Settings.Default.RememberMe;

            if (rememberMeCheckbox.Checked)
            {
                login_textbox.Text = Properties.Settings.Default.UserLogin;
                password_textbox.SetSecureText(ConvertToSecureString(Properties.Settings.Default.UserPassword));
            }
        }

        private string GetFullNameFromDatabase(string email, string tableName)
        {
            string fullName = "";

            MySqlCommand fullNameCommand = new MySqlCommand($"SELECT FullName FROM {tableName} WHERE Email = @Email", _database.GetConnection());
            _ = fullNameCommand.Parameters.AddWithValue("@Email", email);

            try
            {
                _database.OpenConnection();
                object result = fullNameCommand.ExecuteScalar();

                if (result != null)
                {
                    fullName = result.ToString();
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ошибка при получении ФИО: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _database.CloseConnection();
            }

            return fullName;
        }
        private void SetGreeting(Label label)
        {
            DateTime now = DateTime.Now;
            int hour = now.Hour;

            label.Text = hour >= 9 && hour <= 11 ? "Доброе утро!" : hour >= 12 && hour <= 18 ? "Добрый день!" : "Добрый вечер!";
        }
        private void Register_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register frm_register = new Register();
            frm_register.Show();
            Hide();
        }
        private void PassRecover_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PassRecover passRecover = new PassRecover();
            passRecover.Show();
            Hide();
        }
        private void ClosePic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool CheckInternetConnection()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    using (System.IO.Stream stream = client.OpenRead("https://www.google.com"))
                    {
                        return true;
                    }
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
        private void RememberMeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!rememberMeCheckbox.Checked)
            {
                Properties.Settings.Default.UserPassword = "";
                Properties.Settings.Default.Save();
            }
        }
        private string ConvertToUnsecureString(SecureString securePassword)
        {
            if (securePassword == null)
            {
                throw new ArgumentNullException(nameof(securePassword));
            }
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                return System.Runtime.InteropServices.Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
        private SecureString ConvertToSecureString(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }
            SecureString securePassword = new SecureString();
            foreach (char c in password)
            {
                securePassword.AppendChar(c);
            }
            return securePassword;
        }

        private void TogglePasswordVisibility()
        {
            if (password_textbox.PasswordChar == '*')
            {
                password_textbox.PasswordChar = '\0';
                guna2PictureBox1.Image = Properties.Resources.visible_pass;
            }
            else
            {
                password_textbox.PasswordChar = '*';
                guna2PictureBox1.Image = Properties.Resources.invisible_pass;
            }
        }

        private void TogglePasswordVisibilityPic_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }

        private void Login_textbox_MouseHover(object sender, EventArgs e)
        {
            _tooltip.Show("Введите ваш email", login_textbox);
        }

        private void Password_textbox_MouseHover(object sender, EventArgs e)
        {
            _tooltip.Show("Введите ваш пароль", password_textbox);
        }
    }
    public static class SecureStringTextBox
    {
        public static SecureString GetSecureText(this Guna2TextBox textbox)
        {
            if (textbox == null)
            {
                throw new ArgumentNullException(nameof(textbox));
            }

            SecureString secureString = new SecureString();
            foreach (char c in textbox.Text)
            {
                secureString.AppendChar(c);
            }
            return secureString;
        }
        public static void SetSecureText(this Guna2TextBox textbox, SecureString secureString)
        {
            if (textbox == null)
            {
                throw new ArgumentNullException(nameof(textbox));
            }

            if (secureString == null)
            {
                throw new ArgumentNullException(nameof(secureString));
            }

            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocUnicode(secureString);
                textbox.Text = System.Runtime.InteropServices.Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}