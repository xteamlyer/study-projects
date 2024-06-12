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
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addUserControl(calls);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addUserControl(plans);
        }
    }
}
