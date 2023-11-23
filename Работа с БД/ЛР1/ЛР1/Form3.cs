using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ЛР1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = тур_фирма; Integrated Security = True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Пользователи", sqlConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Boolean логин = true;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Логин"].ToString() == textBox7.Text)
                    {
                        логин = false;
                    }
                }
                if ((textBox6.Text == "" || textBox7.Text == "" || textBox1.Text == "" || textBox2.Text == ""))
                {
                    MessageBox.Show("Введите все значения!", "Ошибка");
                }
                else
                {
                    if (логин == false)
                    {
                        MessageBox.Show("Пользователь уже существует!!!");
                    }
                    else
                    {
                        int n = dataGridView1.Rows.Count;
                        {
                            SqlDataAdapter info1 = new SqlDataAdapter($"INSERT INTO Туристы (Код_туриста,Фамилия,Имя,Отчество)VALUES('{n}','{textBox1.Text}','{textBox2.Text}','{textBox3.Text}');", sqlConnect);
                            SqlDataAdapter info2 = new SqlDataAdapter($"INSERT INTO Пользователи (Код_туриста,Логин,Пароль)VALUES('{n}','{textBox7.Text}','{textBox6.Text}');", sqlConnect);
                            DataTable dt1 = new DataTable();
                            DataTable dt2 = new DataTable();
                            info1.Fill(dt1);
                            info2.Fill(dt2);
                        }
                        Form2 f2 = new Form2();
                        this.Hide();
                        f2.Show();
                    }
                   
                }
                }
        }
        
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox6.Focus();
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.Focus();
            }
            
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тур_фирмаDataSet.Туристы". При необходимости она может быть перемещена или удалена.
            this.туристыTableAdapter.Fill(this.тур_фирмаDataSet.Туристы);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
