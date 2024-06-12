using Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using Travel4Everyone.UserControls;

namespace Travel4Everyone
{
    public partial class ModeratorsForm : Form
    {
        private readonly ModerEvents moderEvents = new ModerEvents();
        private readonly ModerActivities moderActivities = new ModerActivities();
        private ModerProfile moderProfile;

        public ModeratorsForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            moderProfile = new ModerProfile(label1.Text);
            guna2Button3_Click(this, EventArgs.Empty);
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void SetButtonState(bool moderEvents, bool moderActivities, bool moderProfile)
        {
            guna2Button1.Checked = moderEvents;
            guna2Button2.Checked = moderActivities;
            guna2Button3.Checked = moderProfile;
        }
        private void moderEvents_Click(object sender, EventArgs e)
        {
            AddUserControl(moderEvents);
            moderEvents.dataGridView1.Size = new Size(1000, 669);
            SetButtonState(true, false, false);
            moderEvents.RefreshDataGrid(moderEvents.dataGridView1);
        }
        private void moderActivities_Click(object sender, EventArgs e)
        {
            AddUserControl(moderActivities);
            moderActivities.dataGridView1.Size = new Size(1000, 669);
            SetButtonState(false, true, false);
            moderActivities.RefreshDataGrid(moderActivities.dataGridView1, label1.Text);
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddUserControl(moderProfile);
            SetButtonState(false, false, true);
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

        private void qrBtn_Click(object sender, EventArgs e)
        {
            // Ссылка, для которой нужно сгенерировать QR-код
            string url = "https://forms.gle/dHQq1TnZZpWqpFc57";

            // Создание экземпляра формы для отображения QR-кода
            QRCodeForm qrCodeForm = new QRCodeForm(url);

            // Отображение формы
            qrCodeForm.Show();
        }
    }
}