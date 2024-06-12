namespace TelephoneCompany.Forms
{
    partial class Report2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.telephoneCompanyDataSet1 = new TelephoneCompany.TelephoneCompanyDataSet1();
            this.scalarQuery5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scalarQuery5TableAdapter = new TelephoneCompany.TelephoneCompanyDataSet1TableAdapters.ScalarQuery5TableAdapter();
            this.кодПлатежаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПлатежаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПлатежаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаПлатежаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneCompanyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalarQuery5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПлатежаDataGridViewTextBoxColumn,
            this.кодКлиентаDataGridViewTextBoxColumn,
            this.фИОКлиентаDataGridViewTextBoxColumn,
            this.датаПлатежаDataGridViewTextBoxColumn,
            this.времяПлатежаDataGridViewTextBoxColumn,
            this.суммаПлатежаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.scalarQuery5BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // telephoneCompanyDataSet1
            // 
            this.telephoneCompanyDataSet1.DataSetName = "TelephoneCompanyDataSet1";
            this.telephoneCompanyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scalarQuery5BindingSource
            // 
            this.scalarQuery5BindingSource.DataMember = "ScalarQuery5";
            this.scalarQuery5BindingSource.DataSource = this.telephoneCompanyDataSet1;
            // 
            // scalarQuery5TableAdapter
            // 
            this.scalarQuery5TableAdapter.ClearBeforeFill = true;
            // 
            // кодПлатежаDataGridViewTextBoxColumn
            // 
            this.кодПлатежаDataGridViewTextBoxColumn.DataPropertyName = "Код платежа";
            this.кодПлатежаDataGridViewTextBoxColumn.HeaderText = "Код платежа";
            this.кодПлатежаDataGridViewTextBoxColumn.Name = "кодПлатежаDataGridViewTextBoxColumn";
            this.кодПлатежаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            // 
            // фИОКлиентаDataGridViewTextBoxColumn
            // 
            this.фИОКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ФИО клиента";
            this.фИОКлиентаDataGridViewTextBoxColumn.HeaderText = "ФИО клиента";
            this.фИОКлиентаDataGridViewTextBoxColumn.Name = "фИОКлиентаDataGridViewTextBoxColumn";
            // 
            // датаПлатежаDataGridViewTextBoxColumn
            // 
            this.датаПлатежаDataGridViewTextBoxColumn.DataPropertyName = "Дата платежа";
            this.датаПлатежаDataGridViewTextBoxColumn.HeaderText = "Дата платежа";
            this.датаПлатежаDataGridViewTextBoxColumn.Name = "датаПлатежаDataGridViewTextBoxColumn";
            // 
            // времяПлатежаDataGridViewTextBoxColumn
            // 
            this.времяПлатежаDataGridViewTextBoxColumn.DataPropertyName = "Время платежа";
            this.времяПлатежаDataGridViewTextBoxColumn.HeaderText = "Время платежа";
            this.времяПлатежаDataGridViewTextBoxColumn.Name = "времяПлатежаDataGridViewTextBoxColumn";
            // 
            // суммаПлатежаDataGridViewTextBoxColumn
            // 
            this.суммаПлатежаDataGridViewTextBoxColumn.DataPropertyName = "Сумма платежа";
            this.суммаПлатежаDataGridViewTextBoxColumn.HeaderText = "Сумма платежа";
            this.суммаПлатежаDataGridViewTextBoxColumn.Name = "суммаПлатежаDataGridViewTextBoxColumn";
            // 
            // Report2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Report2";
            this.Text = "Report2";
            this.Load += new System.EventHandler(this.Report2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneCompanyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalarQuery5BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TelephoneCompanyDataSet1 telephoneCompanyDataSet1;
        private System.Windows.Forms.BindingSource scalarQuery5BindingSource;
        private TelephoneCompanyDataSet1TableAdapters.ScalarQuery5TableAdapter scalarQuery5TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПлатежаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПлатежаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПлатежаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаПлатежаDataGridViewTextBoxColumn;
    }
}