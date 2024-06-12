using MySqlConnector;
using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Travel4Everyone
{
	public partial class PassRecover : Form
	{
		private readonly DataBase _database = new DataBase();
		public PassRecover()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void PassRecover_Load(object sender, EventArgs e)
		{
			CheckConnections();
		}

		private void PassRecoverBtn_click(object sender, EventArgs e)
		{
			CheckConnections();
			string email = email_textbox.Text.Trim(); // Изменяем переменную на email
			if (string.IsNullOrEmpty(email))
			{
				_ = MessageBox.Show("Пароль и электронная почта не могут быть пустыми!", "Введите значения!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			try
			{
				if (CheckIfUserExistsByEmail(email)) // Используем функцию поиска пользователя по email
				{
					// Генерация нового пароля
					string newPassword = GenerateNewPassword();

					// Изменение пароля в базе данных
					ChangePass(email, newPassword);

					// Отправка email с новым паролем
					SendEmail(email, newPassword);

					_ = MessageBox.Show("Новый пароль был отправлен на ваш адрес электронной почты.", "Успешно");

					Login frm_login = new Login();
					Close();
					_ = frm_login.ShowDialog();
				}
				else
				{
					_ = MessageBox.Show("Пользователь с таким email не найден");
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

		private bool CheckIfUserExistsByEmail(string email) // Новая функция для поиска пользователя по email
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

		private void ChangePass(string email, string passUser)
		{
			string querystring = $"UPDATE `users` SET `password` = @passUser WHERE `users`.`email` = @email";
			MySqlCommand command = new MySqlCommand(querystring, _database.GetConnection());
			_ = command.Parameters.AddWithValue("@passUser", passUser);
			_ = command.Parameters.AddWithValue("@email", email);

			_database.OpenConnection();
			_ = command.ExecuteNonQuery();
			_database.CloseConnection();
		}

		private void SendEmail(string email, string newPassword)
		{
			string smtpServer = "smtp-relay.sendinblue.com"; // SMTP-сервер для GMail
			int smtpPort = 587; // Порт для GMail
			string fromEmail = "daniil.klimyuk@gmail.com"; // Адрес электронной почты, с которого будет отправлено письмо
			string fromPassword = "JXKPk2rb53VEWMjA"; // Пароль от адреса электронной почты
			string toEmail = email; // Адрес электронной почты, на который будет отправлено письмо
			string subject = "Восстановление пароля"; // Тема письма
			string body = $"Ваш новый пароль: {newPassword}"; // Текст письма

			using (MailMessage mailMessage = new MailMessage())
			{
				mailMessage.From = new MailAddress(fromEmail);
				mailMessage.To.Add(toEmail);
				mailMessage.Subject = subject;
				mailMessage.Body = body;

				using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
				{
					smtpClient.UseDefaultCredentials = false;
					smtpClient.Credentials = new NetworkCredential(fromEmail, fromPassword);
					smtpClient.EnableSsl = true;
					smtpClient.Send(mailMessage);
				}
			}
		}

		private string GenerateNewPassword()
		{
			Random random = new Random();
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
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

		private void ClosePic_Click(object sender, EventArgs e)
		{
			Login frm_login = new Login();
			Close();
			frm_login.Show();
		}

		private void PassRecover_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}