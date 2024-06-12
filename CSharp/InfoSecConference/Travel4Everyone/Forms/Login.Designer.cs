namespace Travel4Everyone
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.register_label = new System.Windows.Forms.Label();
            this.register_linklabel = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.Label();
            this.rememberMeCheckbox = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.login_button = new Guna.UI2.WinForms.Guna2Button();
            this.login_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.password_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.captcha_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.BackColor = System.Drawing.Color.Transparent;
            this.register_label.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F, System.Drawing.FontStyle.Bold);
            this.register_label.ForeColor = System.Drawing.Color.White;
            this.register_label.Location = new System.Drawing.Point(172, 73);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(125, 23);
            this.register_label.TabIndex = 10;
            this.register_label.Text = "Вход в аккаунт";
            // 
            // register_linklabel
            // 
            this.register_linklabel.AutoSize = true;
            this.register_linklabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.register_linklabel.LinkColor = System.Drawing.Color.Silver;
            this.register_linklabel.Location = new System.Drawing.Point(122, 372);
            this.register_linklabel.Name = "register_linklabel";
            this.register_linklabel.Size = new System.Drawing.Size(222, 17);
            this.register_linklabel.TabIndex = 16;
            this.register_linklabel.TabStop = true;
            this.register_linklabel.Text = "Нет аккаунта? Зарегистрировать";
            this.register_linklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_linklabel_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 70);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(432, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.ClosePic_Click);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13F, System.Drawing.FontStyle.Bold);
            this.logo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.logo.Location = new System.Drawing.Point(100, 24);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(263, 22);
            this.logo.TabIndex = 1;
            this.logo.Text = "Огранизатор мероприятий \"InfoSec\"";
            // 
            // rememberMeCheckbox
            // 
            this.rememberMeCheckbox.AutoSize = true;
            this.rememberMeCheckbox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.rememberMeCheckbox.ForeColor = System.Drawing.Color.White;
            this.rememberMeCheckbox.Location = new System.Drawing.Point(162, 297);
            this.rememberMeCheckbox.Name = "rememberMeCheckbox";
            this.rememberMeCheckbox.Size = new System.Drawing.Size(134, 21);
            this.rememberMeCheckbox.TabIndex = 18;
            this.rememberMeCheckbox.Text = "Запомнить меня";
            this.rememberMeCheckbox.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.Location = new System.Drawing.Point(172, 277);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 17);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Забыли пароль?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PassRecover_linklabel_LinkClicked);
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
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // login_button
            // 
            this.login_button.Animated = true;
            this.login_button.BorderColor = System.Drawing.Color.White;
            this.login_button.BorderRadius = 5;
            this.login_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_button.FillColor = System.Drawing.Color.Black;
            this.login_button.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.HoverState.BorderColor = System.Drawing.Color.White;
            this.login_button.HoverState.FillColor = System.Drawing.Color.White;
            this.login_button.HoverState.ForeColor = System.Drawing.Color.Black;
            this.login_button.Location = new System.Drawing.Point(122, 324);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(222, 45);
            this.login_button.TabIndex = 28;
            this.login_button.Text = "Войти";
            this.login_button.Click += new System.EventHandler(this.Login_button_Click);
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
            this.login_textbox.Location = new System.Drawing.Point(122, 114);
            this.login_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login_textbox.MaxLength = 50;
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.PasswordChar = '\0';
            this.login_textbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.login_textbox.PlaceholderText = "Email";
            this.login_textbox.SelectedText = "";
            this.login_textbox.Size = new System.Drawing.Size(229, 43);
            this.login_textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.login_textbox.TabIndex = 29;
            this.login_textbox.MouseHover += new System.EventHandler(this.Login_textbox_MouseHover);
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
            this.password_textbox.Location = new System.Drawing.Point(122, 162);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_textbox.MaxLength = 50;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.password_textbox.PlaceholderText = "Пароль";
            this.password_textbox.SelectedText = "";
            this.password_textbox.Size = new System.Drawing.Size(229, 43);
            this.password_textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.password_textbox.TabIndex = 30;
            this.password_textbox.MouseHover += new System.EventHandler(this.Password_textbox_MouseHover);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Properties.Resources.invisible_pass;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(357, 173);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(32, 32);
            this.guna2PictureBox1.TabIndex = 31;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.TogglePasswordVisibilityPic_Click);
            // 
            // captcha_textbox
            // 
            this.captcha_textbox.Animated = true;
            this.captcha_textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.captcha_textbox.BorderRadius = 5;
            this.captcha_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.captcha_textbox.DefaultText = "";
            this.captcha_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.captcha_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.captcha_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.captcha_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.captcha_textbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.captcha_textbox.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.captcha_textbox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.captcha_textbox.ForeColor = System.Drawing.Color.White;
            this.captcha_textbox.HoverState.BorderColor = System.Drawing.Color.Black;
            this.captcha_textbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("captcha_textbox.IconLeft")));
            this.captcha_textbox.Location = new System.Drawing.Point(122, 213);
            this.captcha_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.captcha_textbox.MaxLength = 50;
            this.captcha_textbox.Name = "captcha_textbox";
            this.captcha_textbox.PasswordChar = '\0';
            this.captcha_textbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.captcha_textbox.PlaceholderText = "Сколько будет 1+4?";
            this.captcha_textbox.SelectedText = "";
            this.captcha_textbox.Size = new System.Drawing.Size(229, 43);
            this.captcha_textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.captcha_textbox.TabIndex = 32;
            // 
            // Login
            // 
            this.AcceptButton = this.login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(470, 423);
            this.Controls.Add(this.captcha_textbox);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.login_textbox);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.rememberMeCheckbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.register_linklabel);
            this.Controls.Add(this.register_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.LinkLabel register_linklabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.CheckBox rememberMeCheckbox;
		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2Button login_button;
		private Guna.UI2.WinForms.Guna2TextBox login_textbox;
		private Guna.UI2.WinForms.Guna2TextBox password_textbox;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox captcha_textbox;
    }
}