namespace Travel4Everyone.Forms.Adds
{
    partial class Add_Bookings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Bookings));
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.textBox_tour_id = new Guna.UI2.WinForms.Guna2TextBox();
			this.textBox_client_id = new Guna.UI2.WinForms.Guna2TextBox();
			this.addbtn = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
			this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox3.Location = new System.Drawing.Point(360, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 10;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.ClosePic_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new System.Drawing.Point(90, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 27);
			this.label2.TabIndex = 25;
			this.label2.Text = "Новая бронь";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox4.Location = new System.Drawing.Point(1, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(80, 80);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 24;
			this.pictureBox4.TabStop = false;
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
			// textBox_tour_id
			// 
			this.textBox_tour_id.Animated = true;
			this.textBox_tour_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.textBox_tour_id.BorderRadius = 5;
			this.textBox_tour_id.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox_tour_id.DefaultText = "";
			this.textBox_tour_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.textBox_tour_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.textBox_tour_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_tour_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_tour_id.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.textBox_tour_id.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.textBox_tour_id.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_tour_id.ForeColor = System.Drawing.Color.White;
			this.textBox_tour_id.HoverState.BorderColor = System.Drawing.Color.Black;
			this.textBox_tour_id.Location = new System.Drawing.Point(71, 100);
			this.textBox_tour_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox_tour_id.MaxLength = 2000000000;
			this.textBox_tour_id.Name = "textBox_tour_id";
			this.textBox_tour_id.PasswordChar = '\0';
			this.textBox_tour_id.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.textBox_tour_id.PlaceholderText = "ID тура";
			this.textBox_tour_id.SelectedText = "";
			this.textBox_tour_id.Size = new System.Drawing.Size(260, 43);
			this.textBox_tour_id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.textBox_tour_id.TabIndex = 30;
			// 
			// textBox_client_id
			// 
			this.textBox_client_id.Animated = true;
			this.textBox_client_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.textBox_client_id.BorderRadius = 5;
			this.textBox_client_id.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox_client_id.DefaultText = "";
			this.textBox_client_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.textBox_client_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.textBox_client_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_client_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_client_id.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.textBox_client_id.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.textBox_client_id.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_client_id.ForeColor = System.Drawing.Color.White;
			this.textBox_client_id.HoverState.BorderColor = System.Drawing.Color.Black;
			this.textBox_client_id.Location = new System.Drawing.Point(71, 150);
			this.textBox_client_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox_client_id.MaxLength = 2000000000;
			this.textBox_client_id.Name = "textBox_client_id";
			this.textBox_client_id.PasswordChar = '\0';
			this.textBox_client_id.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.textBox_client_id.PlaceholderText = "ID клиента";
			this.textBox_client_id.SelectedText = "";
			this.textBox_client_id.Size = new System.Drawing.Size(260, 43);
			this.textBox_client_id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.textBox_client_id.TabIndex = 31;
			// 
			// addbtn
			// 
			this.addbtn.Animated = true;
			this.addbtn.BorderColor = System.Drawing.Color.White;
			this.addbtn.BorderRadius = 5;
			this.addbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.addbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.addbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.addbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.addbtn.FillColor = System.Drawing.Color.Black;
			this.addbtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.addbtn.ForeColor = System.Drawing.Color.White;
			this.addbtn.HoverState.BorderColor = System.Drawing.Color.White;
			this.addbtn.HoverState.FillColor = System.Drawing.Color.White;
			this.addbtn.HoverState.ForeColor = System.Drawing.Color.Black;
			this.addbtn.Location = new System.Drawing.Point(95, 254);
			this.addbtn.Name = "addbtn";
			this.addbtn.Size = new System.Drawing.Size(222, 45);
			this.addbtn.TabIndex = 33;
			this.addbtn.Text = "Добавить";
			this.addbtn.Click += new System.EventHandler(this.AddBtn_click);
			// 
			// guna2Separator1
			// 
			this.guna2Separator1.Location = new System.Drawing.Point(1, 83);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new System.Drawing.Size(401, 10);
			this.guna2Separator1.TabIndex = 34;
			// 
			// guna2DateTimePicker1
			// 
			this.guna2DateTimePicker1.Animated = true;
			this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
			this.guna2DateTimePicker1.BorderRadius = 5;
			this.guna2DateTimePicker1.Checked = true;
			this.guna2DateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.guna2DateTimePicker1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.White;
			this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.guna2DateTimePicker1.Location = new System.Drawing.Point(71, 200);
			this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.guna2DateTimePicker1.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
			this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
			this.guna2DateTimePicker1.ShowUpDown = true;
			this.guna2DateTimePicker1.Size = new System.Drawing.Size(260, 36);
			this.guna2DateTimePicker1.TabIndex = 35;
			this.guna2DateTimePicker1.Value = new System.DateTime(2023, 5, 10, 0, 0, 0, 0);
			// 
			// Add_Bookings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.ClientSize = new System.Drawing.Size(404, 311);
			this.Controls.Add(this.guna2DateTimePicker1);
			this.Controls.Add(this.guna2Separator1);
			this.Controls.Add(this.addbtn);
			this.Controls.Add(this.textBox_client_id);
			this.Controls.Add(this.textBox_tour_id);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Add_Bookings";
			this.Text = "Add_Plans";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private Guna.UI2.WinForms.Guna2TextBox textBox_tour_id;
		private Guna.UI2.WinForms.Guna2TextBox textBox_client_id;
		private Guna.UI2.WinForms.Guna2Button addbtn;
		private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
		private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
	}
}