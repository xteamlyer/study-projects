namespace Travel4Everyone.UserControls
{
    partial class Bookings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bookings));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox_id = new System.Windows.Forms.TextBox();
			this.save_btn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.del_btn = new System.Windows.Forms.Button();
			this.new_btn = new System.Windows.Forms.Button();
			this.textBox_name = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_first_name = new System.Windows.Forms.TextBox();
			this.textBox_last_name = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
			this.change_btn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.guna2DateTimePicker1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.textBox_id);
			this.panel1.Controls.Add(this.save_btn);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.change_btn);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.del_btn);
			this.panel1.Controls.Add(this.new_btn);
			this.panel1.Controls.Add(this.textBox_name);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBox_first_name);
			this.panel1.Controls.Add(this.textBox_last_name);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.panel1.ForeColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(0, 476);
			this.panel1.Margin = new System.Windows.Forms.Padding(5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1000, 193);
			this.panel1.TabIndex = 17;
			// 
			// guna2DateTimePicker1
			// 
			this.guna2DateTimePicker1.Animated = true;
			this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
			this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.White;
			this.guna2DateTimePicker1.BorderThickness = 1;
			this.guna2DateTimePicker1.Checked = true;
			this.guna2DateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.guna2DateTimePicker1.FillColor = System.Drawing.Color.Black;
			this.guna2DateTimePicker1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.White;
			this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.guna2DateTimePicker1.Location = new System.Drawing.Point(186, 115);
			this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.guna2DateTimePicker1.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
			this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
			this.guna2DateTimePicker1.ShowUpDown = true;
			this.guna2DateTimePicker1.Size = new System.Drawing.Size(357, 26);
			this.guna2DateTimePicker1.TabIndex = 36;
			this.guna2DateTimePicker1.Value = new System.DateTime(2023, 5, 10, 0, 0, 0, 0);
			// 
			// button1
			// 
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(691, 100);
			this.button1.Margin = new System.Windows.Forms.Padding(0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(197, 45);
			this.button1.TabIndex = 32;
			this.button1.Text = "Вывод в CSV";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ExportToCSVBtn_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(739, 5);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(90, 90);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.RefreshPic_Click);
			// 
			// textBox_id
			// 
			this.textBox_id.BackColor = System.Drawing.Color.Black;
			this.textBox_id.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_id.ForeColor = System.Drawing.Color.White;
			this.textBox_id.Location = new System.Drawing.Point(186, 7);
			this.textBox_id.Margin = new System.Windows.Forms.Padding(5);
			this.textBox_id.Name = "textBox_id";
			this.textBox_id.ReadOnly = true;
			this.textBox_id.Size = new System.Drawing.Size(357, 26);
			this.textBox_id.TabIndex = 3;
			// 
			// save_btn
			// 
			this.save_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.save_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
			this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.save_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.save_btn.ForeColor = System.Drawing.Color.White;
			this.save_btn.Image = ((System.Drawing.Image)(resources.GetObject("save_btn.Image")));
			this.save_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.save_btn.Location = new System.Drawing.Point(250, 145);
			this.save_btn.Margin = new System.Windows.Forms.Padding(0);
			this.save_btn.Name = "save_btn";
			this.save_btn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.save_btn.Size = new System.Drawing.Size(250, 45);
			this.save_btn.TabIndex = 3;
			this.save_btn.Text = "Сохранить";
			this.save_btn.UseVisualStyleBackColor = true;
			this.save_btn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(159, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "ID";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(31, 118);
			this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(145, 18);
			this.label6.TabIndex = 14;
			this.label6.Text = "Дата бронировалия";
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
			this.del_btn.Location = new System.Drawing.Point(499, 145);
			this.del_btn.Margin = new System.Windows.Forms.Padding(0);
			this.del_btn.Name = "del_btn";
			this.del_btn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.del_btn.Size = new System.Drawing.Size(250, 45);
			this.del_btn.TabIndex = 1;
			this.del_btn.Text = "Удалить";
			this.del_btn.UseVisualStyleBackColor = true;
			this.del_btn.Click += new System.EventHandler(this.DelBtn_Click);
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
			this.new_btn.Location = new System.Drawing.Point(748, 145);
			this.new_btn.Margin = new System.Windows.Forms.Padding(0);
			this.new_btn.Name = "new_btn";
			this.new_btn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.new_btn.Size = new System.Drawing.Size(250, 45);
			this.new_btn.TabIndex = 0;
			this.new_btn.Text = "Новая запись";
			this.new_btn.UseVisualStyleBackColor = true;
			this.new_btn.Click += new System.EventHandler(this.NewBtn_Click);
			// 
			// textBox_name
			// 
			this.textBox_name.BackColor = System.Drawing.Color.Black;
			this.textBox_name.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_name.ForeColor = System.Drawing.Color.White;
			this.textBox_name.Location = new System.Drawing.Point(186, 34);
			this.textBox_name.Margin = new System.Windows.Forms.Padding(5);
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size(357, 26);
			this.textBox_name.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(101, 37);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 18);
			this.label2.TabIndex = 6;
			this.label2.Text = "Название";
			// 
			// textBox_first_name
			// 
			this.textBox_first_name.BackColor = System.Drawing.Color.Black;
			this.textBox_first_name.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_first_name.ForeColor = System.Drawing.Color.White;
			this.textBox_first_name.Location = new System.Drawing.Point(186, 60);
			this.textBox_first_name.Margin = new System.Windows.Forms.Padding(5);
			this.textBox_first_name.Name = "textBox_first_name";
			this.textBox_first_name.Size = new System.Drawing.Size(357, 26);
			this.textBox_first_name.TabIndex = 7;
			// 
			// textBox_last_name
			// 
			this.textBox_last_name.BackColor = System.Drawing.Color.Black;
			this.textBox_last_name.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_last_name.ForeColor = System.Drawing.Color.White;
			this.textBox_last_name.Location = new System.Drawing.Point(186, 87);
			this.textBox_last_name.Margin = new System.Windows.Forms.Padding(5);
			this.textBox_last_name.Name = "textBox_last_name";
			this.textBox_last_name.Size = new System.Drawing.Size(357, 26);
			this.textBox_last_name.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(44, 90);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 18);
			this.label3.TabIndex = 8;
			this.label3.Text = "Фамилия клиента";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(79, 63);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 18);
			this.label4.TabIndex = 10;
			this.label4.Text = "Имя клиента";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.dataGridView1.ColumnHeadersHeight = 22;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(1000, 476);
			this.dataGridView1.TabIndex = 15;
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
			this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCellEnter_Click);
			// 
			// change_btn
			// 
			this.change_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.change_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
			this.change_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.change_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.change_btn.ForeColor = System.Drawing.Color.White;
			this.change_btn.Image = ((System.Drawing.Image)(resources.GetObject("change_btn.Image")));
			this.change_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.change_btn.Location = new System.Drawing.Point(0, 145);
			this.change_btn.Margin = new System.Windows.Forms.Padding(0);
			this.change_btn.Name = "change_btn";
			this.change_btn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.change_btn.Size = new System.Drawing.Size(250, 45);
			this.change_btn.TabIndex = 2;
			this.change_btn.Text = "Изменить";
			this.change_btn.UseVisualStyleBackColor = true;
			this.change_btn.Click += new System.EventHandler(this.ChangeBtn_Click);
			// 
			// Bookings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Bookings";
			this.Size = new System.Drawing.Size(1000, 669);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button new_btn;
        public System.Windows.Forms.Panel panel1;
		public Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
		private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
		private System.Windows.Forms.Button change_btn;
	}
}
