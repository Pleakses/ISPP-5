namespace Всторенная_БД
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.турыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поповСЕМДК0101DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.попов_СЕ_МДК_01_01DataSet = new Всторенная_БД.Попов_СЕ_МДК_01_01DataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодТураDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.информацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.турыTableAdapter = new Всторенная_БД.Попов_СЕ_МДК_01_01DataSetTableAdapters.ТурыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.турыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поповСЕМДК0101DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.попов_СЕ_МДК_01_01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(468, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 95);
            this.panel1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.турыBindingSource, "Цена", true));
            this.textBox2.Location = new System.Drawing.Point(3, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 1;
            // 
            // турыBindingSource
            // 
            this.турыBindingSource.DataMember = "Туры";
            this.турыBindingSource.DataSource = this.поповСЕМДК0101DataSetBindingSource;
            // 
            // поповСЕМДК0101DataSetBindingSource
            // 
            this.поповСЕМДК0101DataSetBindingSource.DataSource = this.попов_СЕ_МДК_01_01DataSet;
            this.поповСЕМДК0101DataSetBindingSource.Position = 0;
            // 
            // попов_СЕ_МДК_01_01DataSet
            // 
            this.попов_СЕ_МДК_01_01DataSet.DataSetName = "Попов_СЕ_МДК_01_01DataSet";
            this.попов_СЕ_МДК_01_01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.турыBindingSource, "Название", true));
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТураDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.информацияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.турыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // кодТураDataGridViewTextBoxColumn
            // 
            this.кодТураDataGridViewTextBoxColumn.DataPropertyName = "Код тура";
            this.кодТураDataGridViewTextBoxColumn.HeaderText = "Код тура";
            this.кодТураDataGridViewTextBoxColumn.Name = "кодТураDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // информацияDataGridViewTextBoxColumn
            // 
            this.информацияDataGridViewTextBoxColumn.DataPropertyName = "Информация";
            this.информацияDataGridViewTextBoxColumn.HeaderText = "Информация";
            this.информацияDataGridViewTextBoxColumn.Name = "информацияDataGridViewTextBoxColumn";
            // 
            // турыTableAdapter
            // 
            this.турыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "К авторизации";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 177);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Туры";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.турыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поповСЕМДК0101DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.попов_СЕ_МДК_01_01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Попов_СЕ_МДК_01_01DataSet попов_СЕ_МДК_01_01DataSet;
        private System.Windows.Forms.BindingSource поповСЕМДК0101DataSetBindingSource;
        private System.Windows.Forms.BindingSource турыBindingSource;
        private Попов_СЕ_МДК_01_01DataSetTableAdapters.ТурыTableAdapter турыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТураDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn информацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}