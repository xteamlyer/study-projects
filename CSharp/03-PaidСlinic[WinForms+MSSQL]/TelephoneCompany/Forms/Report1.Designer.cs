namespace TelephoneCompany.Forms
{
    partial class Report1
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
            this.telephoneCompanyDataSet = new TelephoneCompany.TelephoneCompanyDataSet();
            this.scalarQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scalarQueryTableAdapter = new TelephoneCompany.TelephoneCompanyDataSetTableAdapters.ScalarQueryTableAdapter();
            this.кодЗвонкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.началоЗвонкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.конецЗвонкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЗвонкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalarQueryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЗвонкаDataGridViewTextBoxColumn,
            this.кодКлиентаDataGridViewTextBoxColumn,
            this.фИОКлиентаDataGridViewTextBoxColumn,
            this.началоЗвонкаDataGridViewTextBoxColumn,
            this.конецЗвонкаDataGridViewTextBoxColumn,
            this.номерЗвонкаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.scalarQueryBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // telephoneCompanyDataSet
            // 
            this.telephoneCompanyDataSet.DataSetName = "TelephoneCompanyDataSet";
            this.telephoneCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scalarQueryBindingSource
            // 
            this.scalarQueryBindingSource.DataMember = "ScalarQuery";
            this.scalarQueryBindingSource.DataSource = this.telephoneCompanyDataSet;
            // 
            // scalarQueryTableAdapter
            // 
            this.scalarQueryTableAdapter.ClearBeforeFill = true;
            // 
            // кодЗвонкаDataGridViewTextBoxColumn
            // 
            this.кодЗвонкаDataGridViewTextBoxColumn.DataPropertyName = "Код звонка";
            this.кодЗвонкаDataGridViewTextBoxColumn.HeaderText = "Код звонка";
            this.кодЗвонкаDataGridViewTextBoxColumn.Name = "кодЗвонкаDataGridViewTextBoxColumn";
            this.кодЗвонкаDataGridViewTextBoxColumn.ReadOnly = true;
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
            // началоЗвонкаDataGridViewTextBoxColumn
            // 
            this.началоЗвонкаDataGridViewTextBoxColumn.DataPropertyName = "Начало звонка";
            this.началоЗвонкаDataGridViewTextBoxColumn.HeaderText = "Начало звонка";
            this.началоЗвонкаDataGridViewTextBoxColumn.Name = "началоЗвонкаDataGridViewTextBoxColumn";
            // 
            // конецЗвонкаDataGridViewTextBoxColumn
            // 
            this.конецЗвонкаDataGridViewTextBoxColumn.DataPropertyName = "Конец звонка";
            this.конецЗвонкаDataGridViewTextBoxColumn.HeaderText = "Конец звонка";
            this.конецЗвонкаDataGridViewTextBoxColumn.Name = "конецЗвонкаDataGridViewTextBoxColumn";
            // 
            // номерЗвонкаDataGridViewTextBoxColumn
            // 
            this.номерЗвонкаDataGridViewTextBoxColumn.DataPropertyName = "Номер звонка";
            this.номерЗвонкаDataGridViewTextBoxColumn.HeaderText = "Номер звонка";
            this.номерЗвонкаDataGridViewTextBoxColumn.Name = "номерЗвонкаDataGridViewTextBoxColumn";
            // 
            // Report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Report1";
            this.Text = "Report1";
            this.Load += new System.EventHandler(this.Report1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalarQueryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TelephoneCompanyDataSet telephoneCompanyDataSet;
        private System.Windows.Forms.BindingSource scalarQueryBindingSource;
        private TelephoneCompanyDataSetTableAdapters.ScalarQueryTableAdapter scalarQueryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЗвонкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn началоЗвонкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn конецЗвонкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗвонкаDataGridViewTextBoxColumn;
    }
}