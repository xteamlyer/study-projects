namespace Travel4Everyone.UserControls
{
    partial class Tours
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tours));
			this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_destination = new System.Windows.Forms.TextBox();
			this.textBox_description = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_price = new System.Windows.Forms.TextBox();
			this.textBox_id = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox_imageurl = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.new_btn = new System.Windows.Forms.Button();
			this.del_btn = new System.Windows.Forms.Button();
			this.change_btn = new System.Windows.Forms.Button();
			this.save_btn = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeight = 22;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(1000, 400);
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
			this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCellEnter_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Black;
			this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(38, 61);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 18);
			this.label4.TabIndex = 10;
			this.label4.Text = "Описание";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Black;
			this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(4, 91);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 14);
			this.label3.TabIndex = 8;
			this.label3.Text = "Место назначения";
			// 
			// textBox_destination
			// 
			this.textBox_destination.BackColor = System.Drawing.Color.Black;
			this.textBox_destination.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_destination.ForeColor = System.Drawing.Color.White;
			this.textBox_destination.Location = new System.Drawing.Point(123, 85);
			this.textBox_destination.Margin = new System.Windows.Forms.Padding(5);
			this.textBox_destination.Name = "textBox_destination";
			this.textBox_destination.Size = new System.Drawing.Size(649, 26);
			this.textBox_destination.TabIndex = 11;
			// 
			// textBox_description
			// 
			this.textBox_description.BackColor = System.Drawing.Color.Black;
			this.textBox_description.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_description.ForeColor = System.Drawing.Color.White;
			this.textBox_description.Location = new System.Drawing.Point(123, 58);
			this.textBox_description.Margin = new System.Windows.Forms.Padding(5);
			this.textBox_description.Name = "textBox_description";
			this.textBox_description.Size = new System.Drawing.Size(649, 26);
			this.textBox_description.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Black;
			this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(69, 114);
			this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 18);
			this.label5.TabIndex = 12;
			this.label5.Text = "Цена";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Black;
			this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(40, 34);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 18);
			this.label2.TabIndex = 6;
			this.label2.Text = "Название";
			// 
			// textBox_name
			// 
			this.textBox_name.BackColor = System.Drawing.Color.Black;
			this.textBox_name.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_name.ForeColor = System.Drawing.Color.White;
			this.textBox_name.Location = new System.Drawing.Point(123, 31);
			this.textBox_name.Margin = new System.Windows.Forms.Padding(5);
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size(649, 26);
			this.textBox_name.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(93, 6);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "ID";
			// 
			// textBox_price
			// 
			this.textBox_price.BackColor = System.Drawing.Color.Black;
			this.textBox_price.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_price.ForeColor = System.Drawing.Color.White;
			this.textBox_price.Location = new System.Drawing.Point(123, 111);
			this.textBox_price.Margin = new System.Windows.Forms.Padding(5);
			this.textBox_price.Name = "textBox_price";
			this.textBox_price.Size = new System.Drawing.Size(649, 26);
			this.textBox_price.TabIndex = 15;
			// 
			// textBox_id
			// 
			this.textBox_id.BackColor = System.Drawing.Color.Black;
			this.textBox_id.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_id.ForeColor = System.Drawing.Color.White;
			this.textBox_id.Location = new System.Drawing.Point(123, 3);
			this.textBox_id.Margin = new System.Windows.Forms.Padding(5);
			this.textBox_id.Name = "textBox_id";
			this.textBox_id.ReadOnly = true;
			this.textBox_id.Size = new System.Drawing.Size(649, 26);
			this.textBox_id.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Black;
			this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(22, 140);
			this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 18);
			this.label6.TabIndex = 16;
			this.label6.Text = "Дата начала";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Black;
			this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(27, 165);
			this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 18);
			this.label7.TabIndex = 18;
			this.label7.Text = "Дата конца";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Black;
			this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(12, 190);
			this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(103, 18);
			this.label8.TabIndex = 20;
			this.label8.Text = "Изображение";
			// 
			// textBox_imageurl
			// 
			this.textBox_imageurl.BackColor = System.Drawing.Color.Black;
			this.textBox_imageurl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox_imageurl.ForeColor = System.Drawing.Color.White;
			this.textBox_imageurl.Location = new System.Drawing.Point(123, 187);
			this.textBox_imageurl.Margin = new System.Windows.Forms.Padding(5);
			this.textBox_imageurl.Name = "textBox_imageurl";
			this.textBox_imageurl.Size = new System.Drawing.Size(649, 26);
			this.textBox_imageurl.TabIndex = 21;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(850, 66);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(90, 90);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.RefreshPic_Click);
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
			this.new_btn.Location = new System.Drawing.Point(749, 222);
			this.new_btn.Margin = new System.Windows.Forms.Padding(0);
			this.new_btn.Name = "new_btn";
			this.new_btn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.new_btn.Size = new System.Drawing.Size(249, 45);
			this.new_btn.TabIndex = 26;
			this.new_btn.Text = "Новая запись";
			this.new_btn.UseVisualStyleBackColor = true;
			this.new_btn.Click += new System.EventHandler(this.NewBtn_Click);
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
			this.del_btn.Location = new System.Drawing.Point(500, 222);
			this.del_btn.Margin = new System.Windows.Forms.Padding(0);
			this.del_btn.Name = "del_btn";
			this.del_btn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.del_btn.Size = new System.Drawing.Size(250, 45);
			this.del_btn.TabIndex = 27;
			this.del_btn.Text = "Удалить";
			this.del_btn.UseVisualStyleBackColor = true;
			this.del_btn.Click += new System.EventHandler(this.DelBtn_Click);
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
			this.change_btn.Location = new System.Drawing.Point(0, 222);
			this.change_btn.Margin = new System.Windows.Forms.Padding(0);
			this.change_btn.Name = "change_btn";
			this.change_btn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.change_btn.Size = new System.Drawing.Size(250, 45);
			this.change_btn.TabIndex = 28;
			this.change_btn.Text = "Изменить";
			this.change_btn.UseVisualStyleBackColor = true;
			this.change_btn.Click += new System.EventHandler(this.ChangeBtn_Click);
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
			this.save_btn.Location = new System.Drawing.Point(250, 222);
			this.save_btn.Margin = new System.Windows.Forms.Padding(0);
			this.save_btn.Name = "save_btn";
			this.save_btn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.save_btn.Size = new System.Drawing.Size(250, 45);
			this.save_btn.TabIndex = 29;
			this.save_btn.Text = "Сохранить";
			this.save_btn.UseVisualStyleBackColor = true;
			this.save_btn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// button1
			// 
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(792, 177);
			this.button1.Margin = new System.Windows.Forms.Padding(0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(197, 45);
			this.button1.TabIndex = 30;
			this.button1.Text = "Вывод в CSV";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ExportToCSVBtn_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.guna2DateTimePicker2);
			this.panel1.Controls.Add(this.guna2DateTimePicker1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.save_btn);
			this.panel1.Controls.Add(this.change_btn);
			this.panel1.Controls.Add(this.del_btn);
			this.panel1.Controls.Add(this.new_btn);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.textBox_imageurl);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.textBox_id);
			this.panel1.Controls.Add(this.textBox_price);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textBox_name);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.textBox_description);
			this.panel1.Controls.Add(this.textBox_destination);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.panel1.Location = new System.Drawing.Point(0, 400);
			this.panel1.Margin = new System.Windows.Forms.Padding(5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1000, 269);
			this.panel1.TabIndex = 16;
			// 
			// guna2DateTimePicker1
			// 
			this.guna2DateTimePicker1.Animated = true;
			this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
			this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.White;
			this.guna2DateTimePicker1.BorderThickness = 1;
			this.guna2DateTimePicker1.Checked = true;
			this.guna2DateTimePicker1.CustomFormat = "yyyy-MM-dd";
			this.guna2DateTimePicker1.FillColor = System.Drawing.Color.Black;
			this.guna2DateTimePicker1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.White;
			this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.guna2DateTimePicker1.Location = new System.Drawing.Point(123, 134);
			this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.guna2DateTimePicker1.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
			this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
			this.guna2DateTimePicker1.ShowUpDown = true;
			this.guna2DateTimePicker1.Size = new System.Drawing.Size(649, 26);
			this.guna2DateTimePicker1.TabIndex = 38;
			this.guna2DateTimePicker1.Value = new System.DateTime(2023, 5, 10, 0, 0, 0, 0);
			// 
			// guna2DateTimePicker2
			// 
			this.guna2DateTimePicker2.Animated = true;
			this.guna2DateTimePicker2.BackColor = System.Drawing.Color.Transparent;
			this.guna2DateTimePicker2.BorderColor = System.Drawing.Color.White;
			this.guna2DateTimePicker2.BorderThickness = 1;
			this.guna2DateTimePicker2.Checked = true;
			this.guna2DateTimePicker2.CustomFormat = "yyyy-MM-dd";
			this.guna2DateTimePicker2.FillColor = System.Drawing.Color.Black;
			this.guna2DateTimePicker2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.guna2DateTimePicker2.ForeColor = System.Drawing.Color.White;
			this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.guna2DateTimePicker2.Location = new System.Drawing.Point(123, 160);
			this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.guna2DateTimePicker2.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
			this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
			this.guna2DateTimePicker2.ShowUpDown = true;
			this.guna2DateTimePicker2.Size = new System.Drawing.Size(649, 26);
			this.guna2DateTimePicker2.TabIndex = 39;
			this.guna2DateTimePicker2.Value = new System.DateTime(2023, 5, 10, 0, 0, 0, 0);
			// 
			// Tours
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Tours";
			this.Size = new System.Drawing.Size(1000, 669);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
		public Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_destination;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_imageurl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
		private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
	}
}
