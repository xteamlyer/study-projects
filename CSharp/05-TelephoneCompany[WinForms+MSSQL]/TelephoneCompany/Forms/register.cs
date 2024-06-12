using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TelephoneCompany
{
    public partial class register : Form
    {
        DataBase database = new DataBase();
        public register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void register_Load(object sender, EventArgs e)
        {
            password_textbox.PasswordChar = '*';
            password_textbox.MaxLength = 50;
            login_textbox.MaxLength = 50;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = login_textbox.Text;
            var password = password_textbox.Text;


            string querystring = $"insert into Users(login, password, is_admin) values('{loginUser}', '{password}', 0)";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            database.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт зарегистрирован", "Успешно");
                login frm_login = new login();
                this.Hide();
                frm_login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не зарегистрировался");
            }
            database.closeConnection();


            if (checkUser())
            {
                return;
            }

        }
        private Boolean checkUser()
        {
            var loginUser = login_textbox.Text;
            var passUser = password_textbox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select * from Users where login = '{loginUser}' and password = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже загестрирован");
                return true;
            }
            else { return false; }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
