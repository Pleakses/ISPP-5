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


namespace УП01_ИСПП5_Швидко_ИА
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            if ((textBox5.Text == "") || (textBox4.Text == ""))
            {
                MessageBox.Show("Не все данные заполнены!", "Ошибка");
            }
            else
            {
                using (SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Швидко_ИА; Integrated Security = True"))
                {
                    SqlDataAdapter info = new SqlDataAdapter($"INSERT INTO Пользователи (Логин,Пароль) VALUES('{textBox5.Text}','{textBox4.Text}');", sqlConnect);
                    DataTable tt = new DataTable();
                    info.Fill(tt);
                }

                MessageBox.Show("Вы зарегестрированы как 'Гость'", "Уведомление");

                Form2 AvtFrm = new Form2();
                AvtFrm.Show();
                this.Hide();
            }
        }
    }
}
