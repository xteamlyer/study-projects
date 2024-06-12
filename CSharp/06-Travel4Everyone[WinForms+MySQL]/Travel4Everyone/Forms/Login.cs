using Guna.UI2.WinForms;
using MySqlConnector;
using System;
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
			rememberMeCheckbox.Checked = Properties.Settings.Default.RememberMe;
			if (rememberMeCheckbox.Checked)
			{
				login_textbox.Text = Properties.Settings.Default.UserLogin;
				password_textbox.SetSecureText(ConvertToSecureString(Properties.Settings.Default.UserPassword));
			}
			// добавляем подсказки для текстовых полей логина и пароля
			_tooltip.SetToolTip(login_textbox, "Введите ваш логин");
			_tooltip.SetToolTip(password_textbox, "Введите ваш пароль");
		}
		public void Login_button_Click(object sender, EventArgs e)
		{
			string loginUser = login_textbox.Text.Trim();
			SecureString passUser = password_textbox.GetSecureText().Copy();
			CheckConnections();
			if (string.IsNullOrEmpty(loginUser) || passUser.Length == 0)
			{
				_ = MessageBox.Show("Пароль и логин не должны быть пустыми!", "Введите значения!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			// проверяем логин на соответствие регулярному выражению
			if (!Regex.IsMatch(loginUser, "^[A-Za-z0-9]+$"))
			{
				_tooltip.Show("Логин может содержать только буквы и цифры.", login_textbox);
				return;
			}
			try
			{
				MySqlCommand command = new MySqlCommand($"SELECT * FROM users WHERE login= @loginUser AND password= @passUser", _database.GetConnection());
				_ = command.Parameters.AddWithValue("@loginUser", loginUser);
				_ = command.Parameters.AddWithValue("@passUser", ConvertToUnsecureString(passUser));

				_database.OpenConnection();
				using (MySqlDataReader reader = command.ExecuteReader())
				{
					if (reader.HasRows)
					{
						_ = reader.Read();
						string role = reader.GetString("role");
						if (rememberMeCheckbox.Checked) // сохраняем данные пользователя, если чекбокс был отмечен
						{
							Properties.Settings.Default.RememberMe = true;
							Properties.Settings.Default.UserLogin = login_textbox.Text;
							Properties.Settings.Default.UserPassword = ConvertToUnsecureString(passUser);
							Properties.Settings.Default.Save();
						}
						if (role == "admin")
						{
							_ = MessageBox.Show($"Вы успешно вошли как: {loginUser}\nВы являетесь администратором!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
							Admin admin = new Admin();
							admin.label1.Text = login_textbox.Text;
							admin.Show();
						}
						else
						{
							_ = MessageBox.Show($"Вы успешно вошли как: {loginUser}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
							Main main = new Main();
							main.label1.Text = login_textbox.Text;
							main.Show();
						}
						Hide();
					}
					else
					{
						_ = MessageBox.Show("Неверный логин или пароль");
					}
				}
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
			if (!rememberMeCheckbox.Checked)
			{
				password_textbox.Text = "";
				Properties.Settings.Default.UserPassword = "";
				Properties.Settings.Default.Save();
			}
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
			_tooltip.Show("Введите ваш логин", login_textbox);
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