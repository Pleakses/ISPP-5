namespace Всторенная_БД
{
    partial class Form9
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
            this.кодОплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПутевкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оплатаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.попов_СЕ_МДК_01_01DataSet = new Всторенная_БД.Попов_СЕ_МДК_01_01DataSet();
            this.оплатаTableAdapter = new Всторенная_БД.Попов_СЕ_МДК_01_01DataSetTableAdapters.ОплатаTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.оплатаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.попов_СЕ_МДК_01_01DataSet4 = new Всторенная_БД.Попов_СЕ_МДК_01_01DataSet4();
            this.оплатаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.оплатаTableAdapter1 = new Всторенная_БД.Попов_СЕ_МДК_01_01DataSet4TableAdapters.ОплатаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.попов_СЕ_МДК_01_01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.попов_СЕ_МДК_01_01DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодОплатыDataGridViewTextBoxColumn,
            this.кодПутевкиDataGridViewTextBoxColumn,
            this.датаОплатыDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.оплатаBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодОплатыDataGridViewTextBoxColumn
            // 
            this.кодОплатыDataGridViewTextBoxColumn.DataPropertyName = "Код оплаты";
            this.кодОплатыDataGridViewTextBoxColumn.HeaderText = "Код оплаты";
            this.кодОплатыDataGridViewTextBoxColumn.Name = "кодОплатыDataGridViewTextBoxColumn";
            // 
            // кодПутевкиDataGridViewTextBoxColumn
            // 
            this.кодПутевкиDataGridViewTextBoxColumn.DataPropertyName = "Код путевки";
            this.кодПутевкиDataGridViewTextBoxColumn.HeaderText = "Код путевки";
            this.кодПутевкиDataGridViewTextBoxColumn.Name = "кодПутевкиDataGridViewTextBoxColumn";
            // 
            // датаОплатыDataGridViewTextBoxColumn
            // 
            this.датаОплатыDataGridViewTextBoxColumn.DataPropertyName = "Дата оплаты";
            this.датаОплатыDataGridViewTextBoxColumn.HeaderText = "Дата оплаты";
            this.датаОплатыDataGridViewTextBoxColumn.Name = "датаОплатыDataGridViewTextBoxColumn";
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            // 
            // оплатаBindingSource
            // 
            this.оплатаBindingSource.DataMember = "Оплата";
            this.оплатаBindingSource.DataSource = this.попов_СЕ_МДК_01_01DataSet;
            // 
            // попов_СЕ_МДК_01_01DataSet
            // 
            this.попов_СЕ_МДК_01_01DataSet.DataSetName = "Попов_СЕ_МДК_01_01DataSet";
            this.попов_СЕ_МДК_01_01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оплатаTableAdapter
            // 
            this.оплатаTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Вернуться в меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // оплатаBindingSource1
            // 
            this.оплатаBindingSource1.DataMember = "Оплата";
            this.оплатаBindingSource1.DataSource = this.попов_СЕ_МДК_01_01DataSet;
            // 
            // попов_СЕ_МДК_01_01DataSet4
            // 
            this.попов_СЕ_МДК_01_01DataSet4.DataSetName = "Попов_СЕ_МДК_01_01DataSet4";
            this.попов_СЕ_МДК_01_01DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оплатаBindingSource2
            // 
            this.оплатаBindingSource2.DataMember = "Оплата";
            this.оплатаBindingSource2.DataSource = this.попов_СЕ_МДК_01_01DataSet4;
            // 
            // оплатаTableAdapter1
            // 
            this.оплатаTableAdapter1.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 197);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Оплата";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.попов_СЕ_МДК_01_01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.попов_СЕ_МДК_01_01DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Попов_СЕ_МДК_01_01DataSet попов_СЕ_МДК_01_01DataSet;
        private System.Windows.Forms.BindingSource оплатаBindingSource;
        private Попов_СЕ_МДК_01_01DataSetTableAdapters.ОплатаTableAdapter оплатаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодОплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПутевкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource оплатаBindingSource1;
        private Попов_СЕ_МДК_01_01DataSet4 попов_СЕ_МДК_01_01DataSet4;
        private System.Windows.Forms.BindingSource оплатаBindingSource2;
        private Попов_СЕ_МДК_01_01DataSet4TableAdapters.ОплатаTableAdapter оплатаTableAdapter1;
    }
}