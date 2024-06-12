using System;
using System.Windows.Forms;
using Travel4Everyone.Forms.Adds;
using Travel4Everyone.UserControls;

namespace Travel4Everyone
{
    public partial class OrganizersForm : Form
    {
        private readonly OrgEvents orgEvents = new OrgEvents();
        private readonly OrgActivities orgActivities = new OrgActivities();
        private readonly OrgParti orgParti = new OrgParti();
        private readonly OrgJury orgJury = new OrgJury();
        private readonly OrgModer orgModer = new OrgModer();
        private OrgProfile orgProfile;

        public OrganizersForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            orgProfile = new OrgProfile(label1.Text);
            orgProfile_Click(this, EventArgs.Empty);
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void SetButtonState(bool orgEvents, bool orgActivities, bool orgParti, bool orgJury, bool orgModer, bool orgProfile)
        {
            guna2Button1.Checked = orgEvents;
            guna2Button2.Checked = orgActivities;
            guna2Button3.Checked = orgParti;
            guna2Button4.Checked = orgJury;
            guna2Button5.Checked = orgModer;
            guna2Button6.Checked = orgProfile;
        }
        private void orgEvents_Click(object sender, EventArgs e)
        {
            AddUserControl(orgEvents);
            SetButtonState(true, false, false, false, false, false);
            orgEvents.RefreshDataGrid(orgEvents.dataGridView1);
        }
        private void orgActivities_Click(object sender, EventArgs e)
        {
            AddUserControl(orgActivities);
            SetButtonState(false, true, false, false, false, false);
            orgActivities.RefreshDataGrid(orgActivities.dataGridView1);
        }
        private void orgParti_Click(object sender, EventArgs e)
        {
            AddUserControl(orgParti);
            SetButtonState(false, false, true, false, false, false);
            orgParti.RefreshDataGrid(orgParti.dataGridView1);
        }
        private void orgJury_Click(object sender, EventArgs e)
        {
            AddUserControl(orgJury);
            SetButtonState(false, false, false, true, false, false);
            orgJury.RefreshDataGrid(orgJury.dataGridView1);
        }
        private void orgModer_Click(object sender, EventArgs e)
        {
            AddUserControl(orgModer);
            SetButtonState(false, false, false, false, true, false);
            orgModer.RefreshDataGrid(orgModer.dataGridView1);
        }

        private void orgProfile_Click(object sender, EventArgs e)
        {
            AddUserControl(orgProfile);
            SetButtonState(false, false, false, false, false, true);
        }
        private void ClosePic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LogoutPic_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }

        private void AdminMode_Click(object sender, EventArgs e)
        {
            Backups backups = new Backups();
            backups.Show();
        }
    }
}