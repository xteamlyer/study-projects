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
using TelephoneCompany.UserControls;

namespace TelephoneCompany
{
    public partial class Main : Form
    {
        Calls calls = new Calls();
        Plans plans = new Plans();
        Site site = new Site();
        Clients clients = new Clients();
        DataBase database = new DataBase();

        public Main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            calls.CreateColumns();
            calls.RefreshDataGrid(calls.dataGridView1);

            plans.CreateColumns();
            plans.RefreshDataGrid(plans.dataGridView1);

            clients.CreateColumns();
            clients.RefreshDataGrid(clients.dataGridView1);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            addUserControl(calls);
            guna2Button1.Checked = true;
            guna2Button2.Checked = false;
            guna2Button3.Checked = false;
            guna2Button4.Checked = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            addUserControl(plans);
            guna2Button1.Checked = false;
            guna2Button2.Checked = true;
            guna2Button3.Checked = false;
            guna2Button4.Checked = false;

        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            addUserControl(site);
            guna2Button1.Checked = false;
            guna2Button2.Checked = false;
            guna2Button3.Checked = true;
            guna2Button4.Checked = false;
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            addUserControl(clients);
            guna2Button1.Checked = false;
            guna2Button2.Checked = false;
            guna2Button3.Checked = false;
            guna2Button4.Checked = true;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
