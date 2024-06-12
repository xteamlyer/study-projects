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
    public partial class Add_Clients : Form
    {
        DataBase database = new DataBase();
        public Add_Clients()
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
            var address = textBox_address.Text;
            Int64 number;
            int planid;
            
            if (Int64.TryParse(textBox_number.Text, out number) && int.TryParse(textBox_planid.Text, out planid))
            {
                var addQuery = $"insert into Clients (FullName, Address, PhoneNumber, PlanID) values ('{name}', '{address}', '{number}', '{planid}')";
                var command = new SqlCommand(addQuery, database.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись создана!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Запись не создана! Номер и ID тарифа должны быть числовыми!", "Повторите попытку!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }
    }
}
