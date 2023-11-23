using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР1
{
    public partial class Form2 : Form
    {
        public int ogr = 5;
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Введите и Логин и Пароль и Права доступа", "Ошибка");
            }
            else if (ogr == 0)
            {
                label4.Text = "Количество ваших попыток было исчерпанно\nОбратитись к администратору и закройте форму авторизации.";
                button1.Visible = false;
                button3.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button2.Location = new Point(12, 191);
                button2.Size = new Size(287, 25);
            }
            else
            {
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = тур_фирма; Integrated Security = True");
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Пользователи", sqlConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Boolean логин = false;
                Boolean пароль = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((dt.Rows[i]["Логин"].ToString() == textBox1.Text) && (dt.Rows[i]["Пароль"].ToString() == textBox2.Text))
                    {
                        логин = true;пароль = true;textBox3.Text = dt.Rows[i]["Права_доступа"].ToString();
                    }
                     if ((dt.Rows[i]["Логин"].ToString() != textBox1.Text) && (dt.Rows[i]["Пароль"].ToString() == textBox2.Text))
                    {
                        логин = false; пароль = true; 
                    }
                     if ((dt.Rows[i]["Логин"].ToString() == textBox1.Text) && (dt.Rows[i]["Пароль"].ToString() != textBox2.Text))
                    {
                        логин = true; пароль = false; 
                    }
                }
                if (логин== true && пароль==true)
                {
                    if (textBox3.Text == "Гость")
                    {
                        this.Hide();
                        Form4 f4 = new Form4();
                        f4.Show();
                    }
                    if (textBox3.Text == "Администратор")
                    {
                        this.Hide();
                        Form6 f5 = new Form6();
                        f5.Show();
                        f5.Text = "Форма Администратора";
                    }
                    if (textBox3.Text == "Оператор")
                    {
                        this.Hide();
                        Form6 f5 = new Form6();
                        f5.Show();
                        f5.Text = "Форма Оператора";
                    }
                }
                else if (логин == false || пароль == false )
                {
                    MessageBox.Show("Неправельные Логин или Пароль, введите Логин или Пароль еще раз");
                    ogr = ogr - 1;
                    label4.Text = $"Для входа осталось попыток: {ogr}";
                }
                else if (логин == false && пароль == false)
                {
                    MessageBox.Show("Пересоздайте пользователя! Такого пользователя не существует.");
                    ogr = ogr - 1;
                    label4.Text = $"Для входа осталось попыток: {ogr}";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Focus();
            }
            if (e.KeyChar == (char)Keys.Space)
            {
                e.KeyChar -= e.KeyChar;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.Focus();
            }
            if (e.KeyChar == (char)Keys.Space)
            {
                e.KeyChar -= e.KeyChar;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.KeyChar -= e.KeyChar;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
