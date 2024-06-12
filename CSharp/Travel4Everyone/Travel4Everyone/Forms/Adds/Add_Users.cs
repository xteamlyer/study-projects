using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Travel4Everyone.Forms.Adds
{
	public partial class Add_Users : Form
	{
		private readonly DataBase database = new DataBase();

		public Add_Users()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			string login = textBox_login.Text.Trim();
			string password = textBox_password.Text;
			string role = comboBox_role.Text;

			if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
			{
				_ = MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				database.OpenConnection();

				string addQuery = "INSERT INTO users (login, password, role) VALUES (@login, @password, @role)";
				MySqlCommand command = new MySqlCommand(addQuery, database.GetConnection());

				_ = command.Parameters.AddWithValue("@login", login);
				_ = command.Parameters.AddWithValue("@password", password);
				_ = command.Parameters.AddWithValue("@role", role);

				int rowsAffected = command.ExecuteNonQuery();

				_ = rowsAffected > 0
					? MessageBox.Show("Запись создана!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information)
					: MessageBox.Show("Запись не создана!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				_ = MessageBox.Show(ex.Message, "Ошибка выполнения запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				database.CloseConnection();
				Close();
			}
		}
	}
}