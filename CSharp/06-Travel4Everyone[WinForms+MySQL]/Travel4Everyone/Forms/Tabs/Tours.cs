using MySqlConnector;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Travel4Everyone.UserControls
{
	public partial class Tours : UserControl
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
		public Tours()
		{
			InitializeComponent();
			CreateColumns();
		}
		public void CreateColumns()
		{
			_ = dataGridView1.Columns.Add("ID", "ID");
			_ = dataGridView1.Columns.Add("name", "Имя тура");
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
			_ = dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetFloat(4), record.GetValue(5), record.GetValue(6), record.GetString(7), RowState.ModifiedNew);
			dgw.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd";
			dgw.Columns[6].DefaultCellStyle.Format = "yyyy-MM-dd";
			dgw.Columns[8].Visible = false;
		}
		public void RefreshDataGrid(DataGridView dgw)
		{
			dgw.Rows.Clear();
			string querystring = $"select * from tours";
			MySqlCommand command = new MySqlCommand(querystring, database.GetConnection());
			database.OpenConnection();
			MySqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				ReadSingleRow(dgw, reader);
			}
			reader.Close();
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
				textBox_description.Text = row.Cells[2].Value.ToString();
				textBox_destination.Text = row.Cells[3].Value.ToString();
				textBox_price.Text = row.Cells[4].Value.ToString();
				guna2DateTimePicker1.Text = ((DateTime)row.Cells[5].Value).ToString("yyyy-MM-dd");
				guna2DateTimePicker2.Text = ((DateTime)row.Cells[6].Value).ToString("yyyy-MM-dd");
				textBox_imageurl.Text = row.Cells[7].Value.ToString();
			}
		}
		private void DeleteRow()
		{
			int index = dataGridView1.CurrentCell.RowIndex;
			dataGridView1.Rows[index].Visible = false;
			if (dataGridView1.Rows[index].Cells[0].Value == null || dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
			{
				dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
				return;
			}
			dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
		}
		private void UpdateRow()
		{
			try
			{
				database.OpenConnection();
				for (int index = 0; index < dataGridView1.Rows.Count; index++)
				{
					RowState rowState = (RowState)dataGridView1.Rows[index].Cells[8].Value;
					if (rowState == RowState.Existed)
					{
						continue;
					}
					if (rowState == RowState.Deleted)
					{
						int id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
						string deleteQuery = $"delete from tours where id = @id";
						MySqlCommand command = new MySqlCommand(deleteQuery, database.GetConnection());
						_ = command.Parameters.AddWithValue("@id", id);
						_ = command.ExecuteNonQuery();
					}
					if (rowState == RowState.Modified)
					{
						string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
						string name = dataGridView1.Rows[index].Cells[1].Value.ToString();
						string description = dataGridView1.Rows[index].Cells[2].Value.ToString();
						string destination = dataGridView1.Rows[index].Cells[3].Value.ToString();
						string price = dataGridView1.Rows[index].Cells[4].Value.ToString();
						string startdate = dataGridView1.Rows[index].Cells[5].Value.ToString();
						string enddate = dataGridView1.Rows[index].Cells[6].Value.ToString();
						string imageurl = dataGridView1.Rows[index].Cells[7].Value.ToString();
						string changeQuery = $"update tours set name = @name, description = @description, destination = @destination, price = @price, start_date = @startdate, end_date = @enddate, image_url = @imageurl where id = @id";
						MySqlCommand command = new MySqlCommand(changeQuery, database.GetConnection());
						_ = command.Parameters.AddWithValue("@id", id);
						_ = command.Parameters.AddWithValue("@name", name);
						_ = command.Parameters.AddWithValue("@description", description);
						_ = command.Parameters.AddWithValue("@destination", destination);
						_ = command.Parameters.AddWithValue("@price", price);
						_ = command.Parameters.AddWithValue("@startdate", startdate);
						_ = command.Parameters.AddWithValue("@enddate", enddate);
						_ = command.Parameters.AddWithValue("@imageurl", imageurl);
						_ = command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				_ = MessageBox.Show($"Error: {ex.Message}");
			}
			finally
			{
				database.CloseConnection();
			}
		}
		private void ChangeRows()
		{
			int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
			string id = textBox_id.Text;
			string name = textBox_name.Text;
			string description = textBox_description.Text;
			string destination = textBox_destination.Text;
			string startdate = guna2DateTimePicker1.Text;
			string enddate = guna2DateTimePicker2.Text;
			string imageurl = textBox_imageurl.Text;
			if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value == null || dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() == string.Empty)
			{
				_ = MessageBox.Show("Выберите тур для изменения");
				return;
			}
			if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(destination) || string.IsNullOrEmpty(startdate) || string.IsNullOrEmpty(enddate) || string.IsNullOrEmpty(imageurl))
			{
				_ = MessageBox.Show("Пожалуйста, заполните все поля перед сохранением изменений!");
				return;
			}
			if (!float.TryParse(textBox_price.Text, out float price))
			{
				_ = MessageBox.Show("Цена должна быть числом");
				return;
			}
			_ = dataGridView1.Rows[selectedRowIndex].SetValues(id, name, description, destination, price, startdate, enddate, imageurl, RowState.Modified);
		}
		private void RefreshPic_Click(object sender, EventArgs e)
		{
			RefreshDataGrid(dataGridView1);
		}
		private void NewBtn_Click(object sender, EventArgs e)
		{
			Add_Tours add_Tours = new Add_Tours();
			add_Tours.Show();
		}
		private void DelBtn_Click(object sender, EventArgs e)
		{
			DeleteRow();
		}
		private void SaveBtn_Click(object sender, EventArgs e)
		{
			UpdateRow();
		}
		private void ChangeBtn_Click(object sender, EventArgs e)
		{
			ChangeRows();
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
							if (j != 8 || dataGridView1.Rows[i].Cells[8].Value.ToString() != "ModifiedNew")
							{
								// Если это не последний столбец и не восьмой столбец, содержащий "ModifiedNew", то выводим значение ячейки и ";"
								streamWriter.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + ";");
							}
						}
						else
						{
							// Если это последний столбец или восьмой столбец, содержащий "ModifiedNew", то выводим только значение ячейки
							if (j != 8 || dataGridView1.Rows[i].Cells[8].Value.ToString() != "ModifiedNew")
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