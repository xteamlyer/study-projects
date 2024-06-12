namespace Travel4Everyone
{
    partial class Register
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
			this.register_label = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.logo = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.register_button = new Guna.UI2.WinForms.Guna2Button();
			this.password_textbox = new Guna.UI2.WinForms.Guna2TextBox();
			this.login_textbox = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.email_textbox = new Guna.UI2.WinForms.Guna2TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// register_label
			// 
			this.register_label.AutoSize = true;
			this.register_label.BackColor = System.Drawing.Color.Transparent;
			this.register_label.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F, System.Drawing.FontStyle.Bold);
			this.register_label.ForeColor = System.Drawing.Color.White;
			this.register_label.Location = new System.Drawing.Point(178, 73);
			this.register_label.Name = "register_label";
			this.register_label.Size = new System.Drawing.Size(105, 23);
			this.register_label.TabIndex = 3;
			this.register_label.Text = "Регистрация";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(12, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(64, 64);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// logo
			// 
			this.logo.AutoSize = true;
			this.logo.BackColor = System.Drawing.Color.Transparent;
			this.logo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13F, System.Drawing.FontStyle.Bold);
			this.logo.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.logo.Location = new System.Drawing.Point(82, 25);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(322, 22);
			this.logo.TabIndex = 1;
			this.logo.Text = "Туристическая компания «Travel4Everyone»";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(432, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 19;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.ExitPicture_click);
			// 
			// guna2DragControl1
			// 
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2DragControl1.TargetControl = this.panel1;
			this.guna2DragControl1.UseTransparentDrag = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.logo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(464, 70);
			this.panel1.TabIndex = 18;
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
			// register_button
			// 
			this.register_button.Animated = true;
			this.register_button.BorderColor = System.Drawing.Color.White;
			this.register_button.BorderRadius = 5;
			this.register_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.register_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.register_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.register_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.register_button.FillColor = System.Drawing.Color.Black;
			this.register_button.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.register_button.ForeColor = System.Drawing.Color.White;
			this.register_button.HoverState.BorderColor = System.Drawing.Color.White;
			this.register_button.HoverState.FillColor = System.Drawing.Color.White;
			this.register_button.HoverState.ForeColor = System.Drawing.Color.Black;
			this.register_button.Location = new System.Drawing.Point(118, 280);
			this.register_button.Name = "register_button";
			this.register_button.Size = new System.Drawing.Size(222, 45);
			this.register_button.TabIndex = 27;
			this.register_button.Text = "Зарегистрировать аккаунт";
			this.register_button.Click += new System.EventHandler(this.RegisterBtn_click);
			// 
			// password_textbox
			// 
			this.password_textbox.Animated = true;
			this.password_textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.password_textbox.BorderRadius = 5;
			this.password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.password_textbox.DefaultText = "";
			this.password_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.password_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.password_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.password_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.password_textbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.password_textbox.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.password_textbox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.password_textbox.ForeColor = System.Drawing.Color.White;
			this.password_textbox.HoverState.BorderColor = System.Drawing.Color.Black;
			this.password_textbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("password_textbox.IconLeft")));
			this.password_textbox.Location = new System.Drawing.Point(116, 213);
			this.password_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.password_textbox.MaxLength = 200;
			this.password_textbox.Name = "password_textbox";
			this.password_textbox.PasswordChar = '*';
			this.password_textbox.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.password_textbox.PlaceholderText = "Пароль";
			this.password_textbox.SelectedText = "";
			this.password_textbox.Size = new System.Drawing.Size(229, 43);
			this.password_textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.password_textbox.TabIndex = 32;
			// 
			// login_textbox
			// 
			this.login_textbox.Animated = true;
			this.login_textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.login_textbox.BorderRadius = 5;
			this.login_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.login_textbox.DefaultText = "";
			this.login_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.login_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.login_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.login_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.login_textbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.login_textbox.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.login_textbox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.login_textbox.ForeColor = System.Drawing.Color.White;
			this.login_textbox.HoverState.BorderColor = System.Drawing.Color.Black;
			this.login_textbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("login_textbox.IconLeft")));
			this.login_textbox.Location = new System.Drawing.Point(116, 114);
			this.login_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.login_textbox.MaxLength = 50;
			this.login_textbox.Name = "login_textbox";
			this.login_textbox.PasswordChar = '\0';
			this.login_textbox.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.login_textbox.PlaceholderText = "Логин";
			this.login_textbox.SelectedText = "";
			this.login_textbox.Size = new System.Drawing.Size(229, 43);
			this.login_textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.login_textbox.TabIndex = 31;
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = global::Properties.Resources.invisible_pass;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(359, 224);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(32, 32);
			this.guna2PictureBox1.TabIndex = 33;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.UseTransparentBackground = true;
			this.guna2PictureBox1.Click += new System.EventHandler(this.TogglePasswordVisibilityPic_Click);
			// 
			// email_textbox
			// 
			this.email_textbox.Animated = true;
			this.email_textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.email_textbox.BorderRadius = 5;
			this.email_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.email_textbox.DefaultText = "";
			this.email_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.email_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.email_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.email_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.email_textbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.email_textbox.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.email_textbox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.email_textbox.ForeColor = System.Drawing.Color.White;
			this.email_textbox.HoverState.BorderColor = System.Drawing.Color.Black;
			this.email_textbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("email_textbox.IconLeft")));
			this.email_textbox.Location = new System.Drawing.Point(116, 162);
			this.email_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.email_textbox.MaxLength = 50;
			this.email_textbox.Name = "email_textbox";
			this.email_textbox.PasswordChar = '\0';
			this.email_textbox.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.email_textbox.PlaceholderText = "Email";
			this.email_textbox.SelectedText = "";
			this.email_textbox.Size = new System.Drawing.Size(229, 43);
			this.email_textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.email_textbox.TabIndex = 34;
			// 
			// Register
			// 
			this.AcceptButton = this.register_button;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.ClientSize = new System.Drawing.Size(464, 347);
			this.Controls.Add(this.email_textbox);
			this.Controls.Add(this.guna2PictureBox1);
			this.Controls.Add(this.password_textbox);
			this.Controls.Add(this.login_textbox);
			this.Controls.Add(this.register_button);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.register_label);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Register";
			this.Text = "Регистрация";
			this.Load += new System.EventHandler(this.Register_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private Guna.UI2.WinForms.Guna2Button register_button;
		private Guna.UI2.WinForms.Guna2TextBox password_textbox;
		private Guna.UI2.WinForms.Guna2TextBox login_textbox;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2TextBox email_textbox;
	}
}