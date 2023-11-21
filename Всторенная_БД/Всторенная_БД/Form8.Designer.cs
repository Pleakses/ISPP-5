namespace Всторенная_БД
{
    partial class Form8
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
            this.путевкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.путевкиTableAdapter = new Всторенная_БД.Попов_СЕ_МДК_01_01DataSetTableAdapters.ПутевкиTableAdapter();
            this.кодПутевкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодТуристаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСезонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.попов_СЕ_МДК_01_01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.путевкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПутевкиDataGridViewTextBoxColumn,
            this.кодТуристаDataGridViewTextBoxColumn,
            this.кодСезонаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.путевкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // попов_СЕ_МДК_01_01DataSet
            // 
            this.попов_СЕ_МДК_01_01DataSet.DataSetName = "Попов_СЕ_МДК_01_01DataSet";
            this.попов_СЕ_МДК_01_01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // путевкиBindingSource
            // 
            this.путевкиBindingSource.DataMember = "Путевки";
            this.путевкиBindingSource.DataSource = this.попов_СЕ_МДК_01_01DataSet;
            // 
            // путевкиTableAdapter
            // 
            this.путевкиTableAdapter.ClearBeforeFill = true;
            // 
            // кодПутевкиDataGridViewTextBoxColumn
            // 
            this.кодПутевкиDataGridViewTextBoxColumn.DataPropertyName = "Код путевки";
            this.кодПутевкиDataGridViewTextBoxColumn.HeaderText = "Код путевки";
            this.кодПутевкиDataGridViewTextBoxColumn.Name = "кодПутевкиDataGridViewTextBoxColumn";
            // 
            // кодТуристаDataGridViewTextBoxColumn
            // 
            this.кодТуристаDataGridViewTextBoxColumn.DataPropertyName = "Код туриста";
            this.кодТуристаDataGridViewTextBoxColumn.HeaderText = "Код туриста";
            this.кодТуристаDataGridViewTextBoxColumn.Name = "кодТуристаDataGridViewTextBoxColumn";
            // 
            // кодСезонаDataGridViewTextBoxColumn
            // 
            this.кодСезонаDataGridViewTextBoxColumn.DataPropertyName = "Код сезона";
            this.кодСезонаDataGridViewTextBoxColumn.HeaderText = "Код сезона";
            this.кодСезонаDataGridViewTextBoxColumn.Name = "кодСезонаDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Вернуться к меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 203);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Путевки";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.попов_СЕ_МДК_01_01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.путевкиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Попов_СЕ_МДК_01_01DataSet попов_СЕ_МДК_01_01DataSet;
        private System.Windows.Forms.BindingSource путевкиBindingSource;
        private Попов_СЕ_МДК_01_01DataSetTableAdapters.ПутевкиTableAdapter путевкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПутевкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТуристаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСезонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}