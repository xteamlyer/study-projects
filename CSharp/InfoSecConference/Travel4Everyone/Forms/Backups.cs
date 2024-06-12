using MySqlConnector;
using System;
using System.IO;
using System.Windows.Forms;

namespace Travel4Everyone.Forms.Adds
{
    public partial class Backups : Form
    {
        private readonly string ConnectionString = "server=bievlwhqcoznqoddspye-mysql.services.clever-cloud.com;user=uyump16dybce4wps;database=bievlwhqcoznqoddspye;password=4PghoqgVcuyEBUH52L5u;";

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
            string commonAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string backupFolder = Path.Combine(commonAppDataFolder, "InfoSecConf");

            if (!Directory.Exists(backupFolder))
            {
                _ = Directory.CreateDirectory(backupFolder);
            }

            string file = Path.Combine(backupFolder, "backup.sql");

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand())
            using (MySqlBackup mb = new MySqlBackup(cmd))
            {
                cmd.Connection = conn;

                try
                {
                    conn.Open();
                    mb.ExportToFile(file);
                    _ = MessageBox.Show("Бэкап базы данных успешно создан.");
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show($"Ошибка при создании бэкапа: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void Restore()
        {
            string commonAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string backupFolder = Path.Combine(commonAppDataFolder, "InfoSecConf");
            string file = Path.Combine(backupFolder, "backup.sql");

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand())
            using (MySqlBackup mb = new MySqlBackup(cmd))
            {
                cmd.Connection = conn;

                try
                {
                    conn.Open();
                    mb.ImportFromFile(file);
                    _ = MessageBox.Show("База данных успешно восстановлена из бэкапа.");
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show($"Ошибка при восстановлении базы данных: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
