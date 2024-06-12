using Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using Travel4Everyone.UserControls;

namespace Travel4Everyone
{
    public partial class PartiForm : Form
    {
        private readonly PartiEvents partiEvents = new PartiEvents();
        private readonly PartiActivities partiActivities = new PartiActivities();
        private PartiProfile partiProfile;

        public PartiForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            partiProfile = new PartiProfile(label1.Text);
            guna2Button3_Click(this, EventArgs.Empty);
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void SetButtonState(bool partiEvents, bool partiActivities, bool partiProfile)
        {
            guna2Button1.Checked = partiEvents;
            guna2Button2.Checked = partiActivities;
            guna2Button3.Checked = partiProfile;
        }
        private void partiEvents_Click(object sender, EventArgs e)
        {
            AddUserControl(partiEvents);
            partiEvents.dataGridView1.Size = new Size(1000, 669);
            SetButtonState(true, false, false);
            partiEvents.RefreshDataGrid(partiEvents.dataGridView1);
        }
        private void partiActivities_Click(object sender, EventArgs e)
        {
            AddUserControl(partiActivities);
            partiActivities.dataGridView1.Size = new Size(1000, 669);
            SetButtonState(false, true, false);
            partiActivities.RefreshDataGrid(partiActivities.dataGridView1, label1.Text);
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddUserControl(partiProfile);
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