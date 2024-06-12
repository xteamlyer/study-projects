using System;
using System.Drawing;
using System.Windows.Forms;
using Travel4Everyone.UserControls;

namespace Travel4Everyone
{
    public partial class UnknownForm : Form
    {
        private readonly UnknownEvents unknownEvents = new UnknownEvents();
        public UnknownForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            SetGreeting(label3);
            ToursBtn_Click(this, EventArgs.Empty);
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void SetButtonState(bool unknownEvents)
        {
            guna2Button1.Checked = unknownEvents;
        }
        private void ToursBtn_Click(object sender, EventArgs e)
        {
            AddUserControl(unknownEvents);
            unknownEvents.dataGridView1.Size = new Size(1000, 669);
            SetButtonState(true);
            unknownEvents.RefreshDataGrid(unknownEvents.dataGridView1);
        }
        private void ClosePic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }
        private void SetGreeting(Label label)
        {
            DateTime now = DateTime.Now;
            int hour = now.Hour;

            label.Text = hour >= 9 && hour <= 11 ? "Доброе утро!" : hour >= 12 && hour <= 18 ? "Добрый день!" : "Добрый вечер!";
        }
    }
}