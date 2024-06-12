using System;
using System.Drawing;
using System.Windows.Forms;
using Travel4Everyone.UserControls;

namespace Travel4Everyone
{
	public partial class Main : Form
	{
		private readonly Tours tours = new Tours();
		private readonly Bookings bookings = new Bookings();
		private readonly Site site = new Site();
		private readonly Clients clients = new Clients();
		public Main()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}
		private void Form2_Load(object sender, EventArgs e)
		{
		}
		private void AddUserControl(UserControl userControl)
		{
			userControl.Dock = DockStyle.Fill;
			panelContainer.Controls.Clear();
			panelContainer.Controls.Add(userControl);
			userControl.BringToFront();
		}
		private void SetButtonState(bool tours, bool bookings, bool clients, bool site)
		{
			guna2Button1.Checked = tours;
			guna2Button2.Checked = bookings;
			guna2Button3.Checked = clients;
			guna2Button4.Checked = site;
		}
		private void ToursBtn_Click(object sender, EventArgs e)
		{
			AddUserControl(tours);
			tours.panel1.Visible = false;
			tours.dataGridView1.Size = new Size(1000, 669);
			SetButtonState(true, false, false, false);
			tours.RefreshDataGrid(tours.dataGridView1);
		}
		private void BookingsBtn_Click(object sender, EventArgs e)
		{
			AddUserControl(bookings);
			bookings.panel1.Visible = false;
			bookings.dataGridView1.Size = new Size(1000, 669);
			SetButtonState(false, true, false, false);
			bookings.RefreshDataGrid(bookings.dataGridView1);
		}
		private void ClientsBtn_Click(object sender, EventArgs e)
		{
			AddUserControl(clients);
			clients.panel1.Visible = false;
			clients.dataGridView1.Size = new Size(1000, 669);
			SetButtonState(false, false, true, false);
			clients.RefreshDataGrid(clients.dataGridView1);
		}
		private void SiteBtn_Click(object sender, EventArgs e)
		{
			AddUserControl(site);
			SetButtonState(false, false, false, true);
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
	}
}