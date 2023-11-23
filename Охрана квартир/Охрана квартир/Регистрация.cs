using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Охрана_квартир
{
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void выйтиИзПрилоденияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Авторизация ав = new Авторизация();
            Hide();
            ав.Show();
        }

        private void вернутьсяКАвторизацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Регистрация_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Регистрация_Load(object sender, EventArgs e)
        {
            a = 0;
            label16.Visible = true;
            label16.Text = "Шаг 1: Введите личные данные";
            button1.Text = "Далее";
            this.Size = new Size(340, 380);
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            button2.Enabled = false;
        }
        int a = 0;
        public void groupbox()
        {
            if (a == 0)
            {
                label16.Text = "Шаг 1: Введите личные данные";
                groupBox1.Visible = true;
                groupBox1.Location = new Point(12, 48);
                button2.Location = new Point(18, 315);
                button1.Location = new Point(189, 315);
                this.Size = new Size(340, 385);
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                button1.Text = "Далее";
            }
            if (a == 1)
            {
                label16.Text = "Шаг 2: Введите данные своей квартиры";
                button2.Enabled = true;
                groupBox1.Visible = false;
                button2.Location = new Point(18, 353);
                button1.Location = new Point(189, 353);
                groupBox2.Location = new Point(12, 48);
                this.Size = new Size(340, 423);
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                button1.Text = "Далее";
            }
            if (a == 2)
            {
                label16.Text = "Шаг 3: Введите данные дома, \nв котором находится ваша квартира";
                button2.Enabled = true;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                button2.Location = new Point(18, 324);
                button1.Location = new Point(189, 324);
                this.Size = new Size(340, 394);
                groupBox3.Location = new Point(12, 66);
                groupBox3.Visible = true;
                button1.Text = "Оформить";
            }
            if (a > 2)
            {
                a = 2;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Оформить")
            {

            }
            else
            {
                a++;
                groupbox();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a--;
            groupbox();
            if (a == 0)
            {
                a = 0;
                button2.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
