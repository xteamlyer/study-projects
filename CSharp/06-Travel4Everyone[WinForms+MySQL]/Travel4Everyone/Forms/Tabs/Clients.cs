using MySqlConnector;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Travel4Everyone.Forms.Adds;

namespace Travel4Everyone.UserControls
{
	public partial class Clients : UserControl
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
		public Clients()
		{
			InitializeComponent();
			CreateColumns();
		}
		public void CreateColumns()
		{
			_ = dataGridView1.Columns.Add("ID", "ID");
			_ = dataGridView1.Columns.Add("first_name", "Имя клиента");
			_ = dataGridView1.Columns.Add("last_name", "Фамилия клиента");
			_ = dataGridView1.Columns.Add("email", "Email");
			_ = dataGridView1.Columns.Add("phone_number", "Номер телефона");
			_ = dataGridView1.Columns.Add("address", "Адрес");
			_ = dataGridView1.Columns.Add("passport_number", "Номер паспорта");
			_ = dataGridView1.Columns.Add("date_of_birth", "Дата рождения");
			_ = dataGridView1.Columns.Add("IsNew", string.Empty);
		}
		public void ReadSingleRow(DataGridView dgw, IDataRecord record)
		{
			_ = dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetValue(7), RowState.ModifiedNew);
			dgw.Columns[7].DefaultCellStyle.Format = "yyyy-MM-dd";
			dgw.Columns[8].Visible = false;
		}
		public void RefreshDataGrid(DataGridView dgw)
		{
			dgw.Rows.Clear();
			string querystring = $"select * from clients";
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
				textBox_firts_name.Text = row.Cells[1].Value.ToString();
				textBox_last_name.Text = row.Cells[2].Value.ToString();
				textBox_email.Text = row.Cells[3].Value.ToString();
				textBox_phone_number.Text = row.Cells[4].Value.ToString();
				textBox_address.Text = row.Cells[5].Value.ToString();
				textBox_passport_number.Text = row.Cells[6].Value.ToString();
				guna2DateTimePicker1.Text = ((DateTime)row.Cells[7].Value).ToString("yyyy-MM-dd");
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
						string deleteQuery = $"delete from clients where id = @id";
						MySqlCommand command = new MySqlCommand(deleteQuery, database.GetConnection());
						_ = command.Parameters.AddWithValue("@id", id);
						_ = command.ExecuteNonQuery();
					}
					if (rowState == RowState.Modified)
					{
						string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
						string first_name = dataGridView1.Rows[index].Cells[1].Value.ToString();
						string last_name = dataGridView1.Rows[index].Cells[2].Value.ToString();
						string email = dataGridView1.Rows[index].Cells[3].Value.ToString();
						string phone_number = dataGridView1.Rows[index].Cells[4].Value.ToString();
						string address = dataGridView1.Rows[index].Cells[5].Value.ToString();
						string passport_number = dataGridView1.Rows[index].Cells[6].Value.ToString();
						string dateofbirth = dataGridView1.Rows[index].Cells[7].Value.ToString();
						string changeQuery = $"update clients set first_name = @first_name, last_name = @last_name, email = @email, phone_number = @phone_number, address = @address, passport_number = @passport_number, date_of_birth = @dateofbirth where id = @id";
						MySqlCommand command = new MySqlCommand(changeQuery, database.GetConnection());
						_ = command.Parameters.AddWithValue("@id", id);
						_ = command.Parameters.AddWithValue("@first_name", first_name);
						_ = command.Parameters.AddWithValue("@last_name", last_name);
						_ = command.Parameters.AddWithValue("@email", email);
						_ = command.Parameters.AddWithValue("@phone_number", phone_number);
						_ = command.Parameters.AddWithValue("@address", address);
						_ = command.Parameters.AddWithValue("@passport_number", passport_number);
						_ = command.Parameters.AddWithValue("@dateofbirth", dateofbirth);
						_ = command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				_ = MessageBox.Show(ex.Message);
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
			string first_name = textBox_firts_name.Text;
			string last_name = textBox_last_name.Text;
			string email = textBox_email.Text;
			string phone_number = textBox_phone_number.Text;
			string address = textBox_address.Text;
			string passport_number = textBox_passport_number.Text;
			string dateofbirth = guna2DateTimePicker1.Text;
			if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value == null || dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() == string.Empty)
			{
				_ = MessageBox.Show("Выберите клиента для изменения");
				return;
			}
			if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(first_name) || string.IsNullOrEmpty(last_name) || string.IsNullOrEmpty(phone_number) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(passport_number))
			{
				_ = MessageBox.Show("Пожалуйста, заполните все поля перед сохранением изменений!");
				return;
			}
			_ = dataGridView1.Rows[selectedRowIndex].SetValues(id, first_name, last_name, email, phone_number, address, passport_number, dateofbirth, RowState.Modified);
		}
		private void RefreshPic_Click(object sender, EventArgs e)
		{
			RefreshDataGrid(dataGridView1);
		}
		private void NewBtn_Click(object sender, EventArgs e)
		{
			Add_Clients addclients = new Add_Clients();
			addclients.Show();
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