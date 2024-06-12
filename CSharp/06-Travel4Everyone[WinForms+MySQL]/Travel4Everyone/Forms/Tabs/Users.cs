using MySqlConnector;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Travel4Everyone.Forms.Adds;

namespace Travel4Everyone.Forms.Tabs
{
	public partial class Users : UserControl
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
		public Users()
		{
			InitializeComponent();
			CreateColumns();
		}
		public void CreateColumns()
		{
			_ = dataGridView1.Columns.Add("ID", "ID");
			_ = dataGridView1.Columns.Add("login", "Логин");
			_ = dataGridView1.Columns.Add("password", "Пароль");
			_ = dataGridView1.Columns.Add("role", "Роль");
			_ = dataGridView1.Columns.Add("email", "Email");
			_ = dataGridView1.Columns.Add("IsNew", string.Empty);
		}
		public void ReadSingleRow(DataGridView dgw, IDataRecord record)
		{
			_ = dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModifiedNew);
			dgw.Columns[5].Visible = false;
		}
		public void RefreshDataGrid(DataGridView dgw)
		{
			dgw.Rows.Clear();
			string querystring = $"SELECT * FROM `users`";
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
		private void DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			SelectedRow = e.RowIndex;
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView1.Rows[SelectedRow];
				textBox_id.Text = row.Cells[0].Value.ToString();
				textBox_login.Text = row.Cells[1].Value.ToString();
				textBox_password.Text = row.Cells[2].Value.ToString();
				textBox_role.Text = row.Cells[3].Value.ToString();
				textBox_email.Text = row.Cells[4].Value.ToString();
			}
		}
		private void DeleteRow()
		{
			int index = dataGridView1.CurrentCell.RowIndex;
			dataGridView1.Rows[index].Visible = false;
			if (dataGridView1.Rows[index].Cells[0].Value == null || dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
			{
				dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
				return;
			}
			dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
		}
		private void UpdateRow()
		{
			try
			{
				Database.OpenConnection();
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
						string deleteQuery = $"delete from users where id = @id";
						MySqlCommand command = new MySqlCommand(deleteQuery, Database.GetConnection());
						_ = command.Parameters.AddWithValue("@id", id);
						_ = command.ExecuteNonQuery();
					}
					if (rowState == RowState.Modified)
					{
						string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
						string login = dataGridView1.Rows[index].Cells[1].Value.ToString();
						string password = dataGridView1.Rows[index].Cells[2].Value.ToString();
						string role = dataGridView1.Rows[index].Cells[3].Value.ToString();
						string email = dataGridView1.Rows[index].Cells[4].Value.ToString();
						string changeQuery = $"update users set login = @login, password = @password, role = @role, email = @email where id = @id";
						MySqlCommand command = new MySqlCommand(changeQuery, Database.GetConnection());
						_ = command.Parameters.AddWithValue("@id", id);
						_ = command.Parameters.AddWithValue("@login", login);
						_ = command.Parameters.AddWithValue("@password", password);
						_ = command.Parameters.AddWithValue("@role", role);
						_ = command.Parameters.AddWithValue("@email", email);
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
				Database.CloseConnection();
			}
		}
		private void ChangeRows()
		{
			int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
			string id = textBox_id.Text;
			string login = textBox_login.Text;
			string password = textBox_password.Text;
			string role = textBox_role.Text;
			string email = textBox_email.Text;
			if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value == null || dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() == string.Empty)
			{
				_ = MessageBox.Show("Выберите пользователя для изменения");
				return;
			}
			if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(email))
			{
				_ = MessageBox.Show("Пожалуйста, заполните все поля перед сохранением изменений!");
				return;
			}
			if (textBox_role.Text != "user" && textBox_role.Text != "admin")
			{
				_ = MessageBox.Show("Роль может быть только 'user' или 'admin'!");
				return;
			}
			_ = dataGridView1.Rows[selectedRowIndex].SetValues(id, login, password, role, email, RowState.Modified);
		}
		private void NewBtn_Click(object sender, EventArgs e)
		{
			Add_Users add_users = new Add_Users();
			add_users.Show();
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
		private void RefreshPic_Click(object sender, EventArgs e)
		{
			RefreshDataGrid(dataGridView1);
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