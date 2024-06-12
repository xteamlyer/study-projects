using MySqlConnector;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Travel4Everyone.Forms.Adds;

namespace Travel4Everyone.UserControls
{
	public partial class Bookings : UserControl
	{
		private enum RowState
		{
			Existed,
			New,
			Modified,
			ModifiedNew,
			Deleted
		}

		private readonly DataBase database = new DataBase();
		private int selectedRow;

		public Bookings()
		{
			InitializeComponent();
			CreateColumns();
		}

		public void CreateColumns()
		{
			_ = dataGridView1.Columns.Add("ID", "ID");
			_ = dataGridView1.Columns.Add("name", "Имя тура");
			_ = dataGridView1.Columns.Add("first_name", "Имя клиента");
			_ = dataGridView1.Columns.Add("last_name", "Фамилия клиента");
			_ = dataGridView1.Columns.Add("booking_date", "Дата бронирования");
			_ = dataGridView1.Columns.Add("IsNew", string.Empty);
		}

		private void ReadSingleRow(DataGridView dgw, IDataRecord record)
		{
			_ = dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetValue(4), RowState.ModifiedNew);
			dgw.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
			dgw.Columns[5].Visible = false;
		}

		public void RefreshDataGrid(DataGridView dgw)
		{
			dataGridView1.Rows.Clear();

			string queryString = "SELECT `bookings`.`id`, `tours`.`name`, `clients`.`first_name`, `clients`.`last_name`, `bookings`.`booking_date` FROM (`bookings` INNER JOIN `tours` ON `bookings`.`tour_id` = `tours`.`id` INNER JOIN `clients` ON `bookings`.`client_id` = `clients`.`id`) ORDER BY `bookings`.`id` ASC;";

			using (MySqlCommand command = new MySqlCommand(queryString, database.GetConnection()))
			{
				database.OpenConnection();

				using (MySqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						ReadSingleRow(dgw, reader);
					}
				}
			}

			database.CloseConnection();
		}

		private void DataGridViewCellEnter_Click(object sender, DataGridViewCellEventArgs e)
		{
			selectedRow = e.RowIndex;

			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView1.Rows[selectedRow];
				textBox_id.Text = row.Cells[0].Value.ToString();
				textBox_name.Text = row.Cells[1].Value.ToString();
				textBox_first_name.Text = row.Cells[2].Value.ToString();
				textBox_last_name.Text = row.Cells[3].Value.ToString();
				guna2DateTimePicker1.Text = ((DateTime)row.Cells[4].Value).ToString("yyyy-MM-dd HH:mm:ss");
			}
		}

		private void DeleteRow()
		{
			int index = dataGridView1.CurrentCell.RowIndex;
			dataGridView1.Rows[index].Visible = false;
			RowState rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

			if (rowState == RowState.Deleted)
			{
				return;
			}

			dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
		}

		private void UpdateRow()
		{
			try
			{
				database.OpenConnection();

				for (int index = 0; index < dataGridView1.Rows.Count; index++)
				{
					RowState rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

					if (rowState == RowState.Existed)
					{
						continue;
					}

					if (rowState == RowState.Deleted)
					{
						int id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
						string deleteQuery = "DELETE FROM `bookings` WHERE id = @id";
						MySqlCommand command = new MySqlCommand(deleteQuery, database.GetConnection());
						_ = command.Parameters.AddWithValue("@id", id);
						_ = command.ExecuteNonQuery();
					}

					if (rowState == RowState.Modified)
					{
						string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
						string name = dataGridView1.Rows[index].Cells[1].Value.ToString();
						string first_name = dataGridView1.Rows[index].Cells[2].Value.ToString();
						string last_name = dataGridView1.Rows[index].Cells[3].Value.ToString();
						string booking_date = dataGridView1.Rows[index].Cells[4].Value.ToString();
						string updateQuery = "UPDATE bookings INNER JOIN tours ON bookings.tour_id = tours.id INNER JOIN clients ON bookings.client_id = clients.id SET bookings.booking_date = @booking_date, tours.name = @name, clients.first_name = @first_name , clients.last_name = @last_name WHERE bookings.id = @id;";
						MySqlCommand command = new MySqlCommand(updateQuery, database.GetConnection());
						_ = command.Parameters.AddWithValue("@id", id);
						_ = command.Parameters.AddWithValue("@name", name);
						_ = command.Parameters.AddWithValue("@first_name", first_name);
						_ = command.Parameters.AddWithValue("@last_name", last_name);
						_ = command.Parameters.AddWithValue("@booking_date", booking_date);
						_ = command.ExecuteNonQuery();
					}
				}

				dataGridView1.Rows.Clear();
				RefreshDataGrid(dataGridView1);
			}
			finally
			{
				database.CloseConnection();
			}
		}

		private void ChangeRows()
		{
			int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
			if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
			{
				string id = textBox_id.Text;
				string name = textBox_name.Text;
				string first_name = textBox_first_name.Text;
				string last_name = textBox_last_name.Text;
				string booking_date = guna2DateTimePicker1.Text;
				if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(first_name) || string.IsNullOrEmpty(last_name) || string.IsNullOrEmpty(booking_date))
				{
					_ = MessageBox.Show("Пожалуйста, заполните все поля перед сохранением изменений!");
					return;
				}

				if (!DateTime.TryParse(booking_date, out _))
				{
					_ = MessageBox.Show("Неправильный формат даты! Пожалуйста, введите дату в формате 'ГГГГ-ММ-ДД ЧЧ:ММ:CC'.");
					return;
				}
				_ = dataGridView1.Rows[selectedRowIndex].SetValues(id, name, first_name, last_name, booking_date);
				dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
			}
		}

		private void RefreshPic_Click(object sender, EventArgs e)
		{
			RefreshDataGrid(dataGridView1);
		}

		private void NewBtn_Click(object sender, EventArgs e)
		{
			Add_Bookings add_Plans = new Add_Bookings();
			add_Plans.Show();
		}

		private void DelBtn_Click(object sender, EventArgs e)
		{
			DeleteRow();
		}

		private void ChangeBtn_Click(object sender, EventArgs e)
		{
			ChangeRows();
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			UpdateRow();
		}

		private void ExportToCSVBtn_Click(object sender, EventArgs e)
		{
			// Открываем диалог сохранения файла
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "CSV-файл (*.csv)|*.csv",
				Title = "Экспорт данных в CSV"
			};
			_ = saveFileDialog.ShowDialog();

			// Если пользователь выбрал файл, сохраняем данные в него
			if (saveFileDialog.FileName != "")
			{
				// Открываем файл для записи
				StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8);

				// Записываем заголовки столбцов
				for (int i = 0; i < dataGridView1.Columns.Count; i++)
				{
					streamWriter.Write(dataGridView1.Columns[i].HeaderText);
					if (i < dataGridView1.Columns.Count - 1)
					{
						streamWriter.Write(";");
					}
				}
				streamWriter.WriteLine();

				// Записываем данные
				for (int i = 0; i < dataGridView1.Rows.Count; i++)
				{
					for (int j = 0; j < dataGridView1.Columns.Count; j++)
					{
						// Проверяем, что текущий столбец не является последним
						if (j < dataGridView1.Columns.Count - 1)
						{
							// Проверяем, что текущий столбец не является восьмым столбцом, содержащим "ModifiedNew"
							if (j != 5 || dataGridView1.Rows[i].Cells[5].Value.ToString() != "ModifiedNew")
							{
								// Если это не последний столбец и не восьмой столбец, содержащий "ModifiedNew", то выводим значение ячейки и ";"
								streamWriter.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + ";");
							}
						}
						else
						{
							// Если это последний столбец или восьмой столбец, содержащий "ModifiedNew", то выводим только значение ячейки
							if (j != 5 || dataGridView1.Rows[i].Cells[5].Value.ToString() != "ModifiedNew")
							{
								streamWriter.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
							}
						}
					}
					streamWriter.WriteLine();
				}

				// Закрываем файл
				streamWriter.Close();
			}
		}
	}
}