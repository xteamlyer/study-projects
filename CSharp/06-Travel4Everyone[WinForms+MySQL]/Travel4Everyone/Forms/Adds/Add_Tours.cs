using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Travel4Everyone
{
	public partial class Add_Tours : Form
	{
		private readonly DataBase database = new DataBase();
		public Add_Tours()
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
			string name = textBox_name.Text;
			string description = textBox_description.Text;
			string destination = textBox_destination.Text;

			if (!float.TryParse(textBox_price.Text, out float price))
			{
				_ = MessageBox.Show("Цена должна быть числом!", "Неправильный формат цены!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string startdate = textBox_startdate.Text;
			string enddate = textBox_enddate.Text;
			string imageurl = textBox_imageurl.Text;

			string addQuery = "INSERT INTO tours(name, description, destination, price, start_date, end_date, image_url) VALUES (@name, @description, @destination, @price, @start_date, @end_date, @image_url)";

			MySqlCommand command = new MySqlCommand(addQuery, database.GetConnection());
			_ = command.Parameters.AddWithValue("@name", name);
			_ = command.Parameters.AddWithValue("@description", description);
			_ = command.Parameters.AddWithValue("@destination", destination);
			_ = command.Parameters.AddWithValue("@price", price);
			_ = command.Parameters.AddWithValue("@start_date", startdate);
			_ = command.Parameters.AddWithValue("@end_date", enddate);
			_ = command.Parameters.AddWithValue("@image_url", imageurl);

			int rowsAffected = command.ExecuteNonQuery();

			_ = rowsAffected > 0
				? MessageBox.Show("Запись создана!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information)
				: MessageBox.Show("Запись не создана!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

			database.CloseConnection();
		}
	}
}