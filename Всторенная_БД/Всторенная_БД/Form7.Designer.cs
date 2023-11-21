namespace Всторенная_БД
{
    partial class Form7
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
            this.попов_СЕ_МДК_01_01DataSet = new Всторенная_БД.Попов_СЕ_МДК_01_01DataSet();
            this.сезоныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сезоныTableAdapter = new Всторенная_БД.Попов_СЕ_МДК_01_01DataSetTableAdapters.СезоныTableAdapter();
            this.кодСезонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодТураDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНачалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаКонцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сезонЗакрытDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоМестDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.попов_СЕ_МДК_01_01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сезоныBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСезонаDataGridViewTextBoxColumn,
            this.кодТураDataGridViewTextBoxColumn,
            this.датаНачалаDataGridViewTextBoxColumn,
            this.датаКонцаDataGridViewTextBoxColumn,
            this.сезонЗакрытDataGridViewTextBoxColumn,
            this.количествоМестDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сезоныBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // попов_СЕ_МДК_01_01DataSet
            // 
            this.попов_СЕ_МДК_01_01DataSet.DataSetName = "Попов_СЕ_МДК_01_01DataSet";
            this.попов_СЕ_МДК_01_01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сезоныBindingSource
            // 
            this.сезоныBindingSource.DataMember = "Сезоны";
            this.сезоныBindingSource.DataSource = this.попов_СЕ_МДК_01_01DataSet;
            // 
            // сезоныTableAdapter
            // 
            this.сезоныTableAdapter.ClearBeforeFill = true;
            // 
            // кодСезонаDataGridViewTextBoxColumn
            // 
            this.кодСезонаDataGridViewTextBoxColumn.DataPropertyName = "Код сезона";
            this.кодСезонаDataGridViewTextBoxColumn.HeaderText = "Код сезона";
            this.кодСезонаDataGridViewTextBoxColumn.Name = "кодСезонаDataGridViewTextBoxColumn";
            // 
            // кодТураDataGridViewTextBoxColumn
            // 
            this.кодТураDataGridViewTextBoxColumn.DataPropertyName = "Код тура";
            this.кодТураDataGridViewTextBoxColumn.HeaderText = "Код тура";
            this.кодТураDataGridViewTextBoxColumn.Name = "кодТураDataGridViewTextBoxColumn";
            // 
            // датаНачалаDataGridViewTextBoxColumn
            // 
            this.датаНачалаDataGridViewTextBoxColumn.DataPropertyName = "Дата начала";
            this.датаНачалаDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            this.датаНачалаDataGridViewTextBoxColumn.Name = "датаНачалаDataGridViewTextBoxColumn";
            // 
            // датаКонцаDataGridViewTextBoxColumn
            // 
            this.датаКонцаDataGridViewTextBoxColumn.DataPropertyName = "Дата конца";
            this.датаКонцаDataGridViewTextBoxColumn.HeaderText = "Дата конца";
            this.датаКонцаDataGridViewTextBoxColumn.Name = "датаКонцаDataGridViewTextBoxColumn";
            // 
            // сезонЗакрытDataGridViewTextBoxColumn
            // 
            this.сезонЗакрытDataGridViewTextBoxColumn.DataPropertyName = "Сезон закрыт";
            this.сезонЗакрытDataGridViewTextBoxColumn.HeaderText = "Сезон закрыт";
            this.сезонЗакрытDataGridViewTextBoxColumn.Name = "сезонЗакрытDataGridViewTextBoxColumn";
            // 
            // количествоМестDataGridViewTextBoxColumn
            // 
            this.количествоМестDataGridViewTextBoxColumn.DataPropertyName = "Количество мест";
            this.количествоМестDataGridViewTextBoxColumn.HeaderText = "Количество мест";
            this.количествоМестDataGridViewTextBoxColumn.Name = "количествоМестDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(288, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Вернуться к меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 203);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Сезоны";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.попов_СЕ_МДК_01_01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сезоныBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Попов_СЕ_МДК_01_01DataSet попов_СЕ_МДК_01_01DataSet;
        private System.Windows.Forms.BindingSource сезоныBindingSource;
        private Попов_СЕ_МДК_01_01DataSetTableAdapters.СезоныTableAdapter сезоныTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСезонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТураDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаКонцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сезонЗакрытDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоМестDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}