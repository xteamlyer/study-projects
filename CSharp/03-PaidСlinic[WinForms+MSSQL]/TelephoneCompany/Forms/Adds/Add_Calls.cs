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

namespace TelephoneCompany
{
    public partial class Add_Calls : Form
    {
        DataBase database = new DataBase();
        public Add_Calls()
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
            int clientid;
            var callstart = textBox_callstart.Text;
            var callend = textBox_callend.Text;
            Int64 number;
           

            if (int.TryParse(textBox_clientid.Text, out clientid) && Int64.TryParse(textBox_number.Text, out number))
            {
                var addQuery = $"insert into CallHistory (ClientId, CallStart, CallEnd, PhoneNumber) values ('{clientid}', '{callstart}', '{callend}', '{number}')";
                var command = new SqlCommand(addQuery, database.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись создана!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Запись не создана! ID клиента должен быть числовым, как и номер", "Повторите попытку!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }
    }
}
