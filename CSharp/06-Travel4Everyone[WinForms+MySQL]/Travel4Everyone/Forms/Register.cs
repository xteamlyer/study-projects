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
			string loginUser = login_textbox.Text.Trim();
			string passUser = password_textbox.Text.Trim();
			string email = email_textbox.Text.Trim();
			if (string.IsNullOrEmpty(loginUser) || string.IsNullOrEmpty(passUser) || string.IsNullOrEmpty(email))
			{
				_ = MessageBox.Show("Пароль / логин / email не должны быть пустыми!", "Введите значения!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (!Regex.IsMatch(loginUser, "^[A-Za-z0-9]+$"))
			{
				_tooltip.Show("Логин может содержать только буквы и цифры.", login_textbox);
				return;
			}
			if (!Regex.IsMatch(passUser, "^[A-Za-z0-9!?]+$"))
			{
				_tooltip.Show("Пароль может содержать только буквы и цифры и знак вопроса/восклицания.", password_textbox);
				return;
			}
			if (!IsValidEmail(email))
			{
				_ = MessageBox.Show("Неправильный формат почты!", "Введите правильный E-mail!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (CheckIfEmailExists(email))
			{
				_ = MessageBox.Show("Пользователь с таким email уже зарегистрирован");
				return;
			}
			if (CheckIfUserExists(loginUser, passUser))
			{
				_ = MessageBox.Show("Пользователь уже зарегистрирован");
				return;
			}
			try
			{
				AddUserToDatabase(loginUser, passUser, email);
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
		private bool CheckIfUserExists(string loginUser, string passUser)
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			string querystring = $"SELECT * FROM users WHERE login= @loginUser AND password= @passUser";
			MySqlCommand command = new MySqlCommand(querystring, _database.GetConnection());
			_ = command.Parameters.AddWithValue("@loginUser", loginUser);
			_ = command.Parameters.AddWithValue("@passUser", passUser);

			adapter.SelectCommand = command;
			_ = adapter.Fill(table);

			return table.Rows.Count > 0;
		}
		private void AddUserToDatabase(string loginUser, string passUser, string email)
		{
			string querystring = $"INSERT INTO users(login, password, email) VALUES(@loginUser, @passUser, @email)";
			MySqlCommand command = new MySqlCommand(querystring, _database.GetConnection());
			_ = command.Parameters.AddWithValue("@loginUser", loginUser);
			_ = command.Parameters.AddWithValue("@passUser", passUser);
			_ = command.Parameters.AddWithValue("@email", email);

			_database.OpenConnection();
			_ = command.ExecuteNonQuery();
			_database.CloseConnection();
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
		private bool CheckIfEmailExists(string email)
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			string querystring = $"SELECT * FROM users WHERE email= @email";
			MySqlCommand command = new MySqlCommand(querystring, _database.GetConnection());
			_ = command.Parameters.AddWithValue("@email", email);

			adapter.SelectCommand = command;
			_ = adapter.Fill(table);

			return table.Rows.Count > 0;
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
		private void TogglePasswordVisibilityPic_Click(object sender, EventArgs e)
		{
			TogglePasswordVisibility();
		}
	}
}