namespace УП01_ИСПП5_Швидко_ИА
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.roundBtn1 = new Ремонт_пассажирских_вагонов.RoundBtn();
            this.roundBtn2 = new Ремонт_пассажирских_вагонов.RoundBtn();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(140, 37);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(153, 20);
            this.textBox5.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.Location = new System.Drawing.Point(64, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Логин";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(140, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 20);
            this.textBox4.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label8.Location = new System.Drawing.Point(64, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Пароль";
            // 
            // roundBtn1
            // 
            this.roundBtn1.BackColor = System.Drawing.Color.PaleGreen;
            this.roundBtn1.Location = new System.Drawing.Point(118, 122);
            this.roundBtn1.Name = "roundBtn1";
            this.roundBtn1.Radius = 10;
            this.roundBtn1.Size = new System.Drawing.Size(114, 37);
            this.roundBtn1.TabIndex = 23;
            this.roundBtn1.Text = "Подтвердить";
            this.roundBtn1.Click += new System.EventHandler(this.roundBtn1_Click);
            // 
            // roundBtn2
            // 
            this.roundBtn2.BackColor = System.Drawing.Color.PaleGreen;
            this.roundBtn2.Location = new System.Drawing.Point(269, 190);
            this.roundBtn2.Name = "roundBtn2";
            this.roundBtn2.Radius = 10;
            this.roundBtn2.Size = new System.Drawing.Size(75, 29);
            this.roundBtn2.TabIndex = 24;
            this.roundBtn2.Text = "Назад";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(353, 228);
            this.Controls.Add(this.roundBtn2);
            this.Controls.Add(this.roundBtn1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private Ремонт_пассажирских_вагонов.RoundBtn roundBtn1;
        private Ремонт_пассажирских_вагонов.RoundBtn roundBtn2;
    }
}