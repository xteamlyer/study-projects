using Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using Travel4Everyone.UserControls;

namespace Travel4Everyone
{
    public partial class JuryForm : Form
    {
        private readonly JuryEvents juryEvents = new JuryEvents();
        private readonly JuryActivities juryActivities = new JuryActivities();
        private JuryProfile juryProfile;

        public JuryForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            juryProfile = new JuryProfile(label1.Text);
            guna2Button3_Click(this, EventArgs.Empty);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void SetButtonState(bool juryEvents, bool juryActivities, bool juryProfile)
        {
            guna2Button1.Checked = juryEvents;
            guna2Button2.Checked = juryActivities;
            guna2Button3.Checked = juryProfile;
        }

        private void juryEvents_Click(object sender, EventArgs e)
        {
            AddAndConfigureUserControl(juryEvents, true, false, false);
        }

        private void juryActivities_Click(object sender, EventArgs e)
        {
            AddAndConfigureUserControl(juryActivities, false, true, false);
            juryActivities.RefreshDataGrid(juryActivities.dataGridView1, label1.Text);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddAndConfigureUserControl(juryProfile, false, false, true);
        }

        private void AddAndConfigureUserControl(UserControl userControl, bool eventsState, bool activitiesState, bool profileState)
        {
            AddUserControl(userControl);
            SetButtonState(eventsState, activitiesState, profileState);
            if (userControl is JuryEvents)
            {
                ((JuryEvents)userControl).dataGridView1.Size = new Size(1000, 669);
                ((JuryEvents)userControl).RefreshDataGrid(((JuryEvents)userControl).dataGridView1);
            }
            else if (userControl is JuryActivities)
            {
                ((JuryActivities)userControl).dataGridView1.Size = new Size(1000, 669);
            }
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
