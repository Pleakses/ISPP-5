using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Всторенная_БД
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public void Form5_Load(object sender, EventArgs e)
        {
        }
        string a;
        public void ii(string b)
        {
            a = b;
            i1();
        }
        public void i1()
        {
            if (a == "Оператор")
            {
                Text = "Панель Оператора";
                button2.Visible = false;
                Size = new Size(321, 289);
                button8.Text = "Выход";
                button7.Text = "Вернуться к авторизации";
            }
            if (a == "Администратор")
            {
                Text = "Панель Администратора";
                button2.Visible = true;
                Size = new Size(321, 317);
                button2.Text = "Выход";
                button8.Text = "Вернуться к авторизации";
                button7.Text = "Право доступа";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Hide();
            Form1 form1 = new Form1();
            form1.st(a);
            form1.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form8 form1 = new Form8();
            form1.st(a);
            form1.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 form1 = new Form6();
            form1.st(a);
            form1.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form7 form1 = new Form7();
            form1.st(a);
            form1.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "Право доступа")
            {
                Hide();
                Form10 form5 = new Form10();
                form5.st(a);
                form5.Show();
            }
            if (button7.Text == "Вернуться к авторизации")
            {
                Close();
                Form2 form5 = new Form2();
                form5.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "Вернуться к авторизации")
            {
                Close();
                Form2 form5 = new Form2();
                form5.Show();
            }
            if (button8.Text == "Выход")
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form9 form9 = new Form9();
            form9.st(a);
            form9.Show();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            Form11 form9 = new Form11();
            form9.st(a);
            form9.Show();
        }
    }
}
