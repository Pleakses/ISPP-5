using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Всторенная_БД
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int popitki = 6;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                if ((textBox1.Text == "") && (textBox2.Text == "")&& (comboBox1.Text == ""))
                {
                    MessageBox.Show("Заполните все поля!!!");
                }
                else
                {
                    if ((textBox1.Text == "") && (textBox2.Text == ""))
                    {
                        MessageBox.Show("Введите Логин и Пароль!!!");
                    }
                    else
                    {
                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Введите Логин!!!");
                                }
                                else
                                {
                                    if (textBox2.Text == "")
                                    {
                                        MessageBox.Show("Введите Пароль!!!");
                                    }
                        }
                    }

                }
            }
            else
            {
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = попов_СЕ_МДК_01_01; Integrated Security = True");
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Пользователи", sqlConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Boolean log = false, password = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                    if (dt.Rows[i]["Логин"].ToString() == textBox1.Text)
                    {
                        if (dt.Rows[i]["Пароль"].ToString() == textBox2.Text)
                        {
                            password = true;
                            comboBox1.Text = dt.Rows[i]["Права доступа"].ToString();
                        }
                        log = true;
                    }
                if ((password == true) && (log == true))
                {
                    if (comboBox1.Text == "Гость")
                    {
                        this.Hide();
                        Form4 UsrFrm = new Form4();
                        UsrFrm.Show();
                    }
                    if (comboBox1.Text == "Администратор")
                    {
                        this.Hide();
                        Form5 UsrFrm = new Form5();
                        UsrFrm.Show();
                        UsrFrm.ii("Администратор");
                    }
                    if (comboBox1.Text == "Оператор")
                    {
                        this.Hide();
                        Form5 UsrFrm = new Form5();
                        UsrFrm.Show();
                        UsrFrm.ii("Оператор");
                    }

                }
                else
                {
                    if ((password == false) && (log == false))
                    {
                        MessageBox.Show("Данный пользователь отсутвует!!!");
                    }
                    else
                    {
                        
                        if (log == false)
                        {
                            MessageBox.Show("Неверно набран Логин!!!");
                        }
                        else
                        {
                                if (password == false)
                                {
                                    MessageBox.Show("Неверно введен Пароль!!!");
                                    popitki -= 1;
                                    label4.Text = "Количество попыток для ввода Пароля осталось: " + popitki;
                                    if (popitki == 0)
                                    {
                                        label5.Visible = true;
                                        button1.Visible = false;
                                        button2.Location = new Point(113, 125);
                                        button3.Visible = false;
                                    }
                                }
                        }
                    }
                }
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.KeyChar -= e.KeyChar;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.KeyChar -= e.KeyChar;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 UsrFrm = new Form3();
            UsrFrm.Show();
            Form3 form3 = new Form3();
            form3.load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 UsrFrm = new Form4();
            UsrFrm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form11 UsrFrm = new Form11();
            UsrFrm.Show();
        }
    }
}
