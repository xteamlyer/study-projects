namespace Travel4Everyone.UserControls
{
    partial class OrgActivities
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrgActivities));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.del_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeratorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jury1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jury2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jury3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jury4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jury5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Winner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.del_btn);
            this.panel1.Controls.Add(this.new_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 53);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(944, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // del_btn
            // 
            this.del_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.del_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Image = ((System.Drawing.Image)(resources.GetObject("del_btn.Image")));
            this.del_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.del_btn.Location = new System.Drawing.Point(319, 0);
            this.del_btn.Margin = new System.Windows.Forms.Padding(0);
            this.del_btn.Name = "del_btn";
            this.del_btn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.del_btn.Size = new System.Drawing.Size(153, 51);
            this.del_btn.TabIndex = 27;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // new_btn
            // 
            this.new_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.new_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.new_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.new_btn.ForeColor = System.Drawing.Color.White;
            this.new_btn.Image = ((System.Drawing.Image)(resources.GetObject("new_btn.Image")));
            this.new_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_btn.Location = new System.Drawing.Point(472, 0);
            this.new_btn.Margin = new System.Windows.Forms.Padding(0);
            this.new_btn.Name = "new_btn";
            this.new_btn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.new_btn.Size = new System.Drawing.Size(189, 51);
            this.new_btn.TabIndex = 26;
            this.new_btn.Text = "Новая запись";
            this.new_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeight = 22;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ActivityNumber,
            this.EventName,
            this.StartDate,
            this.Duration,
            this.ActivityType,
            this.Day,
            this.StartTime,
            this.ModeratorName,
            this.Jury1,
            this.Jury2,
            this.Jury3,
            this.Jury4,
            this.Jury5,
            this.Winner});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 616);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 22;
            this.dataGridView1.ThemeStyle.ReadOnly = true;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 45;
            // 
            // ActivityNumber
            // 
            this.ActivityNumber.HeaderText = "№";
            this.ActivityNumber.Name = "ActivityNumber";
            this.ActivityNumber.ReadOnly = true;
            this.ActivityNumber.Width = 46;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Название";
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            this.EventName.Width = 98;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Дата начала";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 118;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Длительность(дней)";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 173;
            // 
            // ActivityType
            // 
            this.ActivityType.HeaderText = "Активность";
            this.ActivityType.Name = "ActivityType";
            this.ActivityType.ReadOnly = true;
            this.ActivityType.Width = 113;
            // 
            // Day
            // 
            this.Day.HeaderText = "День";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.Width = 67;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Время начала";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 127;
            // 
            // ModeratorName
            // 
            this.ModeratorName.HeaderText = "Модератор";
            this.ModeratorName.Name = "ModeratorName";
            this.ModeratorName.ReadOnly = true;
            this.ModeratorName.Width = 106;
            // 
            // Jury1
            // 
            this.Jury1.HeaderText = "Жюри 1";
            this.Jury1.Name = "Jury1";
            this.Jury1.ReadOnly = true;
            this.Jury1.Width = 83;
            // 
            // Jury2
            // 
            this.Jury2.HeaderText = "Жюри 2";
            this.Jury2.Name = "Jury2";
            this.Jury2.ReadOnly = true;
            this.Jury2.Width = 86;
            // 
            // Jury3
            // 
            this.Jury3.HeaderText = "Жюри 3";
            this.Jury3.Name = "Jury3";
            this.Jury3.ReadOnly = true;
            this.Jury3.Width = 86;
            // 
            // Jury4
            // 
            this.Jury4.HeaderText = "Жюри 4";
            this.Jury4.Name = "Jury4";
            this.Jury4.ReadOnly = true;
            this.Jury4.Width = 87;
            // 
            // Jury5
            // 
            this.Jury5.HeaderText = "Жюри 5";
            this.Jury5.Name = "Jury5";
            this.Jury5.ReadOnly = true;
            this.Jury5.Width = 86;
            // 
            // Winner
            // 
            this.Winner.HeaderText = "Победитель";
            this.Winner.Name = "Winner";
            this.Winner.ReadOnly = true;
            this.Winner.Width = 113;
            // 
            // OrgActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrgActivities";
            this.Size = new System.Drawing.Size(1000, 669);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeratorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jury1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jury2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jury3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jury4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jury5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Winner;
    }
}
