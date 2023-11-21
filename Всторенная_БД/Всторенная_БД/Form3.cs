﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "попов_СЕ_МДК_01_01DataSet1.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.попов_СЕ_МДК_01_01DataSet1.Пользователи);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void load()
        {
            this.пользователиTableAdapter.Fill(this.попов_СЕ_МДК_01_01DataSet1.Пользователи);
            dataGridView1.Update();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = попов_СЕ_МДК_01_01; Integrated Security = True");
            sqlConnect.Open();
            DataTable dt = new DataTable();
            DataTable dta = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter($"select * from Пользователи", sqlConnect);
            daa.Fill(dta);
            string n = dta.Rows[dta.Rows.Count-1]["Id"].ToString();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT INTO Пользователи (Id,Логин,Пароль) VALUES ('{int.Parse(n)+1}','{textBox1.Text}','{textBox2.Text}');", sqlConnect);
            da.Fill(dt);
            пользователиTableAdapter.Update(попов_СЕ_МДК_01_01DataSet1.Пользователи);
            MessageBox.Show($"Регистрация пользователя с логином {textBox1.Text} выполнена.\nВы зарегистрированы как гость");
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
