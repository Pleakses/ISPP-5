namespace УП01_ИСПП5_Швидко_ИА
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.уП01_ИСПП5_Швидко_ИАDataSet = new УП01_ИСПП5_Швидко_ИА.УП01_ИСПП5_Швидко_ИАDataSet();
            this.упаковкисемянBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.упаковки_семянTableAdapter = new УП01_ИСПП5_Швидко_ИА.УП01_ИСПП5_Швидко_ИАDataSetTableAdapters.Упаковки_семянTableAdapter();
            this.уП01_ИСПП5_Швидко_ИАDataSet1 = new УП01_ИСПП5_Швидко_ИА.УП01_ИСПП5_Швидко_ИАDataSet1();
            this.сортарастенийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сорта_растенийTableAdapter = new УП01_ИСПП5_Швидко_ИА.УП01_ИСПП5_Швидко_ИАDataSet1TableAdapters.Сорта_растенийTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01_ИСПП5_Швидко_ИАDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.упаковкисемянBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01_ИСПП5_Швидко_ИАDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортарастенийBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(806, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(831, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ForeColor = System.Drawing.Color.Red;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton2.Text = "Выход";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton3.Text = "Сорта растений";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton9.Text = "Упаковки семян";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // уП01_ИСПП5_Швидко_ИАDataSet
            // 
            this.уП01_ИСПП5_Швидко_ИАDataSet.DataSetName = "УП01_ИСПП5_Швидко_ИАDataSet";
            this.уП01_ИСПП5_Швидко_ИАDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // упаковкисемянBindingSource
            // 
            this.упаковкисемянBindingSource.DataMember = "Упаковки_семян";
            this.упаковкисемянBindingSource.DataSource = this.уП01_ИСПП5_Швидко_ИАDataSet;
            // 
            // упаковки_семянTableAdapter
            // 
            this.упаковки_семянTableAdapter.ClearBeforeFill = true;
            // 
            // уП01_ИСПП5_Швидко_ИАDataSet1
            // 
            this.уП01_ИСПП5_Швидко_ИАDataSet1.DataSetName = "УП01_ИСПП5_Швидко_ИАDataSet1";
            this.уП01_ИСПП5_Швидко_ИАDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сортарастенийBindingSource
            // 
            this.сортарастенийBindingSource.DataMember = "Сорта_растений";
            this.сортарастенийBindingSource.DataSource = this.уП01_ИСПП5_Швидко_ИАDataSet1;
            // 
            // сорта_растенийTableAdapter
            // 
            this.сорта_растенийTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(831, 342);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01_ИСПП5_Швидко_ИАDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.упаковкисемянBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01_ИСПП5_Швидко_ИАDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортарастенийBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        public System.Windows.Forms.DataGridView dataGridView1;
        private УП01_ИСПП5_Швидко_ИАDataSet уП01_ИСПП5_Швидко_ИАDataSet;
        private System.Windows.Forms.BindingSource упаковкисемянBindingSource;
        private УП01_ИСПП5_Швидко_ИАDataSetTableAdapters.Упаковки_семянTableAdapter упаковки_семянTableAdapter;
        private УП01_ИСПП5_Швидко_ИАDataSet1 уП01_ИСПП5_Швидко_ИАDataSet1;
        private System.Windows.Forms.BindingSource сортарастенийBindingSource;
        private УП01_ИСПП5_Швидко_ИАDataSet1TableAdapters.Сорта_растенийTableAdapter сорта_растенийTableAdapter;
    }
}