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

namespace УП01_ИСПП5_Швидко_ИА
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void roundBtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Поля не должны быть пустыми", "Ошибка");
            }
            else
            {
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Швидко_ИА; Integrated Security = True");
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Пользователи", sqlConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int flag = -1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((dt.Rows[i]["Права_доступа"].ToString() == "Администратор") && (dt.Rows[i]["Логин"].ToString() == textBox1.Text) && (dt.Rows[i]["Пароль"].ToString() == textBox2.Text))
                        flag = 0;
                    if ((dt.Rows[i]["Права_доступа"].ToString() == "Продавец") && (dt.Rows[i]["Логин"].ToString() == textBox1.Text) && (dt.Rows[i]["Пароль"].ToString() == textBox2.Text))
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    if (flag == 0)
                    {
                        this.Hide();
                        Form1 UsrFrm = new Form1();
                        UsrFrm.Show();
                    }
                    if (flag == 1)
                    {
                        this.Hide();
                        Form3 UsrFrm3 = new Form3();
                        UsrFrm3.Show();
                    }
                }
            }
        }
        private void roundBtn3_Click(object sender, EventArgs e)
        {

        }

        private void roundBtn5_Click(object sender, EventArgs e)
        {
            if (roundBtn5.Text == "показать")
            {
                textBox2.PasswordChar = '\0';
                roundBtn5.Text = "скрыть";
            }
            else if (roundBtn5.Text == "скрыть")
            {
                textBox2.PasswordChar = '*';
                roundBtn5.Text = "показать";
            }
        }

        private void roundBtn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 UsrFrm3 = new Form3();
            UsrFrm3.Show();
        }
    }
}
