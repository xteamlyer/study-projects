namespace Travel4Everyone.Forms.Adds
{
    partial class Add_Clients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Clients));
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.button1 = new Guna.UI2.WinForms.Guna2Button();
			this.textBox_email = new Guna.UI2.WinForms.Guna2TextBox();
			this.textBox_last_name = new Guna.UI2.WinForms.Guna2TextBox();
			this.textBox_firts_name = new Guna.UI2.WinForms.Guna2TextBox();
			this.textBox_phone_number = new Guna.UI2.WinForms.Guna2TextBox();
			this.textBox_address = new Guna.UI2.WinForms.Guna2TextBox();
			this.textBox_passport_number = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
			this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new System.Drawing.Point(88, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 27);
			this.label2.TabIndex = 20;
			this.label2.Text = "Новый клиент";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox4.Location = new System.Drawing.Point(2, -1);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(80, 80);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 19;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox3.Location = new System.Drawing.Point(404, -1);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 10;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.ClosePic_Click);
			// 
			// guna2DragControl1
			// 
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2DragControl1.TargetControl = this;
			this.guna2DragControl1.UseTransparentDrag = true;
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.AnimateWindow = true;
			this.guna2BorderlessForm1.AnimationInterval = 250;
			this.guna2BorderlessForm1.BorderRadius = 30;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2BorderlessForm1.ResizeForm = false;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			// 
			// button1
			// 
			this.button1.Animated = true;
			this.button1.BorderColor = System.Drawing.Color.White;
			this.button1.BorderRadius = 5;
			this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.button1.FillColor = System.Drawing.Color.Black;
			this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.HoverState.BorderColor = System.Drawing.Color.White;
			this.button1.HoverState.FillColor = System.Drawing.Color.White;
			this.button1.HoverState.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(108, 362);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(222, 45);
			this.button1.TabIndex = 43;
			this.button1.Text = "Добавить";
			this.button1.Click += new System.EventHandler(this.AddBtn_click);
			// 
			// textBox_email
			// 
			this.textBox_email.Animated = true;
			this.textBox_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.textBox_email.BorderRadius = 5;
			this.textBox_email.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox_email.DefaultText = "";
			this.textBox_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.textBox_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.textBox_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_email.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.textBox_email.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.textBox_email.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_email.ForeColor = System.Drawing.Color.White;
			this.textBox_email.HoverState.BorderColor = System.Drawing.Color.Black;
			this.textBox_email.Location = new System.Drawing.Point(66, 169);
			this.textBox_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox_email.MaxLength = 255;
			this.textBox_email.Name = "textBox_email";
			this.textBox_email.PasswordChar = '\0';
			this.textBox_email.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.textBox_email.PlaceholderText = "Email";
			this.textBox_email.SelectedText = "";
			this.textBox_email.Size = new System.Drawing.Size(312, 28);
			this.textBox_email.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.textBox_email.TabIndex = 42;
			// 
			// textBox_last_name
			// 
			this.textBox_last_name.Animated = true;
			this.textBox_last_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.textBox_last_name.BorderRadius = 5;
			this.textBox_last_name.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox_last_name.DefaultText = "";
			this.textBox_last_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.textBox_last_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.textBox_last_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_last_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_last_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.textBox_last_name.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.textBox_last_name.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_last_name.ForeColor = System.Drawing.Color.White;
			this.textBox_last_name.HoverState.BorderColor = System.Drawing.Color.Black;
			this.textBox_last_name.Location = new System.Drawing.Point(66, 133);
			this.textBox_last_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox_last_name.MaxLength = 50;
			this.textBox_last_name.Name = "textBox_last_name";
			this.textBox_last_name.PasswordChar = '\0';
			this.textBox_last_name.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.textBox_last_name.PlaceholderText = "Фамилия";
			this.textBox_last_name.SelectedText = "";
			this.textBox_last_name.Size = new System.Drawing.Size(312, 28);
			this.textBox_last_name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.textBox_last_name.TabIndex = 41;
			// 
			// textBox_firts_name
			// 
			this.textBox_firts_name.Animated = true;
			this.textBox_firts_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.textBox_firts_name.BorderRadius = 5;
			this.textBox_firts_name.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox_firts_name.DefaultText = "";
			this.textBox_firts_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.textBox_firts_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.textBox_firts_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_firts_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_firts_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.textBox_firts_name.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.textBox_firts_name.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_firts_name.ForeColor = System.Drawing.Color.White;
			this.textBox_firts_name.HoverState.BorderColor = System.Drawing.Color.Black;
			this.textBox_firts_name.Location = new System.Drawing.Point(66, 97);
			this.textBox_firts_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox_firts_name.MaxLength = 50;
			this.textBox_firts_name.Name = "textBox_firts_name";
			this.textBox_firts_name.PasswordChar = '\0';
			this.textBox_firts_name.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.textBox_firts_name.PlaceholderText = "Имя";
			this.textBox_firts_name.SelectedText = "";
			this.textBox_firts_name.Size = new System.Drawing.Size(312, 28);
			this.textBox_firts_name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.textBox_firts_name.TabIndex = 40;
			// 
			// textBox_phone_number
			// 
			this.textBox_phone_number.Animated = true;
			this.textBox_phone_number.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.textBox_phone_number.BorderRadius = 5;
			this.textBox_phone_number.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox_phone_number.DefaultText = "";
			this.textBox_phone_number.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.textBox_phone_number.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.textBox_phone_number.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_phone_number.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_phone_number.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.textBox_phone_number.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.textBox_phone_number.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_phone_number.ForeColor = System.Drawing.Color.White;
			this.textBox_phone_number.HoverState.BorderColor = System.Drawing.Color.Black;
			this.textBox_phone_number.Location = new System.Drawing.Point(66, 205);
			this.textBox_phone_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox_phone_number.MaxLength = 20;
			this.textBox_phone_number.Name = "textBox_phone_number";
			this.textBox_phone_number.PasswordChar = '\0';
			this.textBox_phone_number.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.textBox_phone_number.PlaceholderText = "Номер";
			this.textBox_phone_number.SelectedText = "";
			this.textBox_phone_number.Size = new System.Drawing.Size(312, 28);
			this.textBox_phone_number.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.textBox_phone_number.TabIndex = 44;
			// 
			// textBox_address
			// 
			this.textBox_address.Animated = true;
			this.textBox_address.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.textBox_address.BorderRadius = 5;
			this.textBox_address.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox_address.DefaultText = "";
			this.textBox_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.textBox_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.textBox_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_address.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.textBox_address.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.textBox_address.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_address.ForeColor = System.Drawing.Color.White;
			this.textBox_address.HoverState.BorderColor = System.Drawing.Color.Black;
			this.textBox_address.Location = new System.Drawing.Point(66, 241);
			this.textBox_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox_address.MaxLength = 255;
			this.textBox_address.Name = "textBox_address";
			this.textBox_address.PasswordChar = '\0';
			this.textBox_address.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.textBox_address.PlaceholderText = "Адрес";
			this.textBox_address.SelectedText = "";
			this.textBox_address.Size = new System.Drawing.Size(312, 28);
			this.textBox_address.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.textBox_address.TabIndex = 45;
			// 
			// textBox_passport_number
			// 
			this.textBox_passport_number.Animated = true;
			this.textBox_passport_number.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.textBox_passport_number.BorderRadius = 5;
			this.textBox_passport_number.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox_passport_number.DefaultText = "";
			this.textBox_passport_number.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.textBox_passport_number.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.textBox_passport_number.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_passport_number.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_passport_number.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.textBox_passport_number.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.textBox_passport_number.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_passport_number.ForeColor = System.Drawing.Color.White;
			this.textBox_passport_number.HoverState.BorderColor = System.Drawing.Color.Black;
			this.textBox_passport_number.Location = new System.Drawing.Point(66, 277);
			this.textBox_passport_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox_passport_number.MaxLength = 50;
			this.textBox_passport_number.Name = "textBox_passport_number";
			this.textBox_passport_number.PasswordChar = '\0';
			this.textBox_passport_number.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.textBox_passport_number.PlaceholderText = "Номер паспорта";
			this.textBox_passport_number.SelectedText = "";
			this.textBox_passport_number.Size = new System.Drawing.Size(312, 28);
			this.textBox_passport_number.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.textBox_passport_number.TabIndex = 46;
			// 
			// guna2Separator1
			// 
			this.guna2Separator1.Location = new System.Drawing.Point(2, 80);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new System.Drawing.Size(444, 10);
			this.guna2Separator1.TabIndex = 48;
			// 
			// guna2DateTimePicker1
			// 
			this.guna2DateTimePicker1.Animated = true;
			this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
			this.guna2DateTimePicker1.BorderRadius = 5;
			this.guna2DateTimePicker1.Checked = true;
			this.guna2DateTimePicker1.CustomFormat = "yyyy-MM-dd";
			this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.guna2DateTimePicker1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.White;
			this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.guna2DateTimePicker1.Location = new System.Drawing.Point(66, 312);
			this.guna2DateTimePicker1.MaxDate = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
			this.guna2DateTimePicker1.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
			this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
			this.guna2DateTimePicker1.Size = new System.Drawing.Size(312, 36);
			this.guna2DateTimePicker1.TabIndex = 49;
			this.guna2DateTimePicker1.Value = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
			// 
			// Add_Clients
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.ClientSize = new System.Drawing.Size(444, 419);
			this.Controls.Add(this.guna2DateTimePicker1);
			this.Controls.Add(this.guna2Separator1);
			this.Controls.Add(this.textBox_passport_number);
			this.Controls.Add(this.textBox_address);
			this.Controls.Add(this.textBox_phone_number);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox_email);
			this.Controls.Add(this.textBox_last_name);
			this.Controls.Add(this.textBox_firts_name);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Add_Clients";
			this.Text = "Add_Clients";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private Guna.UI2.WinForms.Guna2TextBox textBox_passport_number;
		private Guna.UI2.WinForms.Guna2TextBox textBox_address;
		private Guna.UI2.WinForms.Guna2TextBox textBox_phone_number;
		private Guna.UI2.WinForms.Guna2Button button1;
		private Guna.UI2.WinForms.Guna2TextBox textBox_email;
		private Guna.UI2.WinForms.Guna2TextBox textBox_last_name;
		private Guna.UI2.WinForms.Guna2TextBox textBox_firts_name;
		private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
		private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
	}
}