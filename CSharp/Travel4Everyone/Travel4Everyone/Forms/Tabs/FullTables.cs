using MySqlConnector;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Travel4Everyone.Forms.Tabs
{
	public partial class FullTables : UserControl
	{
		private enum RowState
		{
			Existed,
			New,
			Modified,
			ModifiedNew,
			Deleted
		}
		internal DataBase Database { get; set; } = new DataBase();
		public int SelectedRow { get; set; }
		public FullTables()
		{
			InitializeComponent();
			CreateColumns();
		}
		public void CreateColumns()
		{
			_ = dataGridView1.Columns.Add("ID", "ID брони");
			_ = dataGridView1.Columns.Add("tour_id", "ID тура");
			_ = dataGridView1.Columns.Add("client_id", "ID Клиента");
			_ = dataGridView1.Columns.Add("booking_date", "Дата брони");
			_ = dataGridView1.Columns.Add("ID", "ID клиента");
			_ = dataGridView1.Columns.Add("first_name", "Имя клиента");
			_ = dataGridView1.Columns.Add("last_name", "Фамилия клиента");
			_ = dataGridView1.Columns.Add("email", "Email");
			_ = dataGridView1.Columns.Add("phone_number", "Номер телефона");
			_ = dataGridView1.Columns.Add("address", "Адрес");
			_ = dataGridView1.Columns.Add("passport_number", "Номер паспорта");
			_ = dataGridView1.Columns.Add("date_of_birth", "Дата рождения");
			_ = dataGridView1.Columns.Add("id", "ID Тура");
			_ = dataGridView1.Columns.Add("name", "Название");
			_ = dataGridView1.Columns.Add("description", "Описание");
			_ = dataGridView1.Columns.Add("destination", "Место назначения");
			_ = dataGridView1.Columns.Add("price", "Цена");
			_ = dataGridView1.Columns.Add("start_date", "Дата начала");
			_ = dataGridView1.Columns.Add("end_date", "Дата конца");
			_ = dataGridView1.Columns.Add("image_url", "Изображение");
			_ = dataGridView1.Columns.Add("IsNew", string.Empty);
		}
		public void ReadSingleRow(DataGridView dgw, IDataRecord record)
		{
			_ = dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetValue(3), record.GetInt32(4), record.GetString(5), record.GetString(6), record.GetString(7), record.GetString(8), record.GetString(9), record.GetString(10), record.GetValue(11), record.GetInt32(12), record.GetString(13), record.GetString(14), record.GetString(15), record.GetFloat(16), record.GetValue(17), record.GetValue(18), record.GetString(19), RowState.ModifiedNew);
			dgw.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd HH:MM:ss";
			dgw.Columns[11].DefaultCellStyle.Format = "yyyy-MM-dd";
			dgw.Columns[17].DefaultCellStyle.Format = "yyyy-MM-dd";
			dgw.Columns[18].DefaultCellStyle.Format = "yyyy-MM-dd";
			dgw.Columns[20].Visible = false;
		}
		public void RefreshDataGrid(DataGridView dgw)
		{
			dgw.Rows.Clear();
			string querystring = $"SELECT * FROM bookings INNER JOIN clients ON bookings.client_id = clients.id INNER JOIN tours ON bookings.tour_id = tours.id ORDER BY `bookings`.`id` ASC;";
			MySqlCommand command = new MySqlCommand(querystring, Database.GetConnection());
			Database.OpenConnection();
			MySqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				ReadSingleRow(dgw, reader);
			}
			reader.Close();
			Database.CloseConnection();
		}

		private void ExportToCSVBtn_Click(object sender, System.EventArgs e)
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
							if (j != 20 || dataGridView1.Rows[i].Cells[20].Value.ToString() != "ModifiedNew")
							{
								// Если это не последний столбец и не восьмой столбец, содержащий "ModifiedNew", то выводим значение ячейки и ";"
								streamWriter.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + ";");
							}
						}
						else
						{
							// Если это последний столбец или восьмой столбец, содержащий "ModifiedNew", то выводим только значение ячейки
							if (j != 20 || dataGridView1.Rows[i].Cells[20].Value.ToString() != "ModifiedNew")
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