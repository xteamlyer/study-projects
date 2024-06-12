using System;
using System.Windows.Forms;
using Travel4Everyone.Forms.Adds;
using Travel4Everyone.Forms.Tabs;
using Travel4Everyone.UserControls;

namespace Travel4Everyone
{
	public partial class Admin : Form
	{
		private readonly Tours tours = new Tours();
		private readonly Bookings bookings = new Bookings();
		private readonly Clients clients = new Clients();
		private readonly Site site = new Site();
		private readonly Users users = new Users();
		private readonly FullTables tables = new FullTables();
		public Admin()
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
		private void SetButtonState(bool tours, bool bookings, bool clients, bool site, bool users, bool tables)
		{
			guna2Button1.Checked = tours;
			guna2Button2.Checked = bookings;
			guna2Button3.Checked = clients;
			guna2Button4.Checked = site;
			guna2Button5.Checked = users;
			guna2Button6.Checked = tables;
		}
		private void ToursBtn_Click(object sender, EventArgs e)
		{
			AddUserControl(tours);
			SetButtonState(true, false, false, false, false, false);
			tours.RefreshDataGrid(tours.dataGridView1);
		}

		private void BookingsBtn_Click(object sender, EventArgs e)
		{
			AddUserControl(bookings);
			SetButtonState(false, true, false, false, false, false);
			bookings.RefreshDataGrid(bookings.dataGridView1);
		}
		private void ClientsBtn_Click(object sender, EventArgs e)
		{
			AddUserControl(clients);
			SetButtonState(false, false, true, false, false, false);
			clients.RefreshDataGrid(clients.dataGridView1);
		}
		private void SiteBtn_Click(object sender, EventArgs e)
		{
			AddUserControl(site);
			SetButtonState(false, false, false, true, false, false);

		}
		private void UsersBtn_Click(object sender, EventArgs e)
		{
			AddUserControl(users);
			SetButtonState(false, false, false, false, true, false);
			users.RefreshDataGrid(users.dataGridView1);
		}
		private void TablesBtn_Click(object sender, EventArgs e)
		{
			AddUserControl(tables);
			SetButtonState(false, false, false, false, false, true);
			tables.RefreshDataGrid(tables.dataGridView1);
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