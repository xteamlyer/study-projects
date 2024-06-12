using MySqlConnector;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Travel4Everyone.Forms.Adds
{
	public partial class Add_Clients : Form
	{
		private readonly DataBase database = new DataBase();
		public Add_Clients()
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
			string first_name = textBox_firts_name.Text;
			string last_name = textBox_last_name.Text;
			string email = textBox_email.Text;
			string phone_number = textBox_phone_number.Text;
			string address = textBox_address.Text;
			string passport_number = textBox_passport_number.Text;
			string dateofbirth = guna2DateTimePicker1.Text;

			if (string.IsNullOrEmpty(first_name) || string.IsNullOrEmpty(last_name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone_number) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(passport_number) || string.IsNullOrEmpty(dateofbirth))
			{
				_ = MessageBox.Show("Значения не должны быть пустыми!", "Введите значения!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!IsValidEmail(email))
			{
				_ = MessageBox.Show("Неправильный формат почты!", "Введите правильный E-mail!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!IsValidPhoneNumber(phone_number))
			{
				_ = MessageBox.Show("Неправильный формат номера телефона!", "Введите правильный номер телефона!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (IsPassportNumberExists(passport_number))
			{
				_ = MessageBox.Show("Паспортный номер уже существует!", "Введите другой паспортный номер!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string addQuery = $"insert into clients(first_name, last_name, email, phone_number, address, passport_number, date_of_birth) values (@first_name, @last_name, @email, @phone_number, @address, @passport_number, @dateofbirth)";
			MySqlCommand command = new MySqlCommand(addQuery, database.GetConnection());
			_ = command.Parameters.AddWithValue("@first_name", first_name);
			_ = command.Parameters.AddWithValue("@last_name", last_name);
			_ = command.Parameters.AddWithValue("@email", email);
			_ = command.Parameters.AddWithValue("@phone_number", phone_number);
			_ = command.Parameters.AddWithValue("@address", address);
			_ = command.Parameters.AddWithValue("@passport_number", passport_number);
			_ = command.Parameters.AddWithValue("@dateofbirth", dateofbirth);
			_ = command.ExecuteNonQuery();

			_ = MessageBox.Show("Запись создана!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

			database.CloseConnection();
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

		private bool IsPassportNumberExists(string passportNumber)
		{
			string selectQuery = $"SELECT * FROM clients WHERE passport_number = @passportNumber";
			MySqlCommand command = new MySqlCommand(selectQuery, database.GetConnection());
			_ = command.Parameters.AddWithValue("@passportNumber", passportNumber);
			MySqlDataReader reader = command.ExecuteReader();

			if (reader.HasRows)
			{
				reader.Close();
				return true;
			}

			reader.Close();
			return false;
		}
	}
}