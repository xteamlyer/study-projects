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
    public partial class login : Form
    {
        DataBase database = new DataBase();
        public login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }
        private void login_Load(object sender, EventArgs e)
        {
            password_textbox.PasswordChar = '*';
            password_textbox.MaxLength = 50;
            login_textbox.MaxLength = 50;
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            var loginUser = login_textbox.Text;
            var passUser = password_textbox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select ID, login, password, is_admin from Users where login = '{loginUser}' and password = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1) 
            {
                MessageBox.Show("Вы успешно вошли", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main frm2 = new Main();
                this.Hide();
                frm2.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Такого аккаунта не существует", "Аккаунт не найден", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void register_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register frm_register = new register();
            frm_register.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
