using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneCompany.Forms.Adds
{
    public partial class Add_Plans : Form
    {
        DataBase database = new DataBase();
        public Add_Plans()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var name = textBox_name.Text;
            var cost = textBox_cost.Text;
            int gigi;
            int minutes;


            if (int.TryParse(textBox_gigi.Text, out gigi) && int.TryParse(textBox_minutes.Text, out minutes))
            {
                var addQuery = $"insert into Plans (Name, Cost, InternetCount, MinutesCount) values ('{name}', '{cost}', '{gigi}', '{minutes}')";
                var command = new SqlCommand(addQuery, database.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись создана!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Запись не создана! Кол-во ГБ и минут должено быть числовым!", "Повторите попытку!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }
    }
}
