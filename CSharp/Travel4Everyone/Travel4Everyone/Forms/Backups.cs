using MySqlConnector;
using System;
using System.IO;
using System.Windows.Forms;

namespace Travel4Everyone.Forms.Adds
{
	public partial class Backups : Form
	{

		public Backups()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			Backup();
		}
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			Restore();
		}
		private void Backup()
		{
			string constring = "server=bvniajs9gycvi86nlzhw-mysql.services.clever-cloud.com;user=ufwojncblj5qpezl;database=bvniajs9gycvi86nlzhw;password=TITuHnVVniReDFUfcPLj;";
			string commonAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
			string backupFolder = Path.Combine(commonAppDataFolder, "Travel4Everyone");
			if (!Directory.Exists(backupFolder))
			{
				_ = Directory.CreateDirectory(backupFolder);
			}
			string file = Path.Combine(backupFolder, "backup.sql");
			using (MySqlConnection conn = new MySqlConnection(constring))
			{
				using (MySqlCommand cmd = new MySqlCommand())
				{
					using (MySqlBackup mb = new MySqlBackup(cmd))
					{
						cmd.Connection = conn;
						conn.Open();
						mb.ExportToFile(file);
						conn.Close();
					}
				}
			}
			_ = MessageBox.Show("Бэкап базы данных успешно создан.");
		}

		private void Restore()
		{
			string constring = "server=bvniajs9gycvi86nlzhw-mysql.services.clever-cloud.com;user=ufwojncblj5qpezl;database=bvniajs9gycvi86nlzhw;password=TITuHnVVniReDFUfcPLj;";
			string commonAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
			string backupFolder = Path.Combine(commonAppDataFolder, "Travel4Everyone");
			string file = Path.Combine(backupFolder, "backup.sql");
			using (MySqlConnection conn = new MySqlConnection(constring))
			{
				using (MySqlCommand cmd = new MySqlCommand())
				{
					using (MySqlBackup mb = new MySqlBackup(cmd))
					{
						cmd.Connection = conn;
						conn.Open();
						mb.ImportFromFile(file);
						conn.Close();
					}
				}
			}
			_ = MessageBox.Show("База данных успешно восстановлена из бэкапа.");
		}
	}
}