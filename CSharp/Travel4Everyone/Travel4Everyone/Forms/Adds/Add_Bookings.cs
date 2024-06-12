using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Travel4Everyone.Forms.Adds
{
	public partial class Add_Bookings : Form
	{
		private readonly DataBase database = new DataBase();
		public Add_Bookings()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			guna2DateTimePicker1.Value = DateTime.Now;
		}
		private void ClosePic_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void AddBtn_click(object sender, EventArgs e)
		{
			database.OpenConnection();
			string booking_date = guna2DateTimePicker1.Text;
			if (int.TryParse(textBox_tour_id.Text, out int tour_id) && int.TryParse(textBox_client_id.Text, out int client_id) && !string.IsNullOrEmpty(booking_date))
			{
				if (!IsTourExists(tour_id))
				{
					_ = MessageBox.Show("Тур не найден!", "Введите правильный ID тура!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (!IsClientExists(client_id))
				{
					_ = MessageBox.Show("Клиент не найден!", "Введите правильный ID клиента!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				string addQuery = $"insert into bookings (tour_id, client_id, booking_date) values (@tour_id, @client_id, @booking_date)";
				MySqlCommand command = new MySqlCommand(addQuery, database.GetConnection());
				_ = command.Parameters.AddWithValue("@tour_id", tour_id);
				_ = command.Parameters.AddWithValue("@client_id", client_id);
				_ = command.Parameters.AddWithValue("@booking_date", booking_date);
				_ = command.ExecuteNonQuery();

				_ = MessageBox.Show("Запись создана!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				_ = MessageBox.Show("Запись не создана!\nID тура и ID клиента должны быть числовыми!", "Повторите попытку!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			database.CloseConnection();
		}

		private bool IsTourExists(int tourId)
		{
			string selectQuery = $"SELECT * FROM tours WHERE id = @tourId";
			MySqlCommand command = new MySqlCommand(selectQuery, database.GetConnection());
			_ = command.Parameters.AddWithValue("@tourId", tourId);
			MySqlDataReader reader = command.ExecuteReader();

			if (reader.HasRows)
			{
				reader.Close();
				return true;
			}

			reader.Close();
			return false;
		}

		private bool IsClientExists(int clientId)
		{
			string selectQuery = $"SELECT * FROM clients WHERE id = @clientId";
			MySqlCommand command = new MySqlCommand(selectQuery, database.GetConnection());
			_ = command.Parameters.AddWithValue("@clientId", clientId);
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