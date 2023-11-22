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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void tab(int i)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Швидко_ИА; Integrated Security = True");
            sqlConnect.Open();
            switch (i)
            {
                case 0: dataGridView1.DataSource = продажиBindingSource; break;
                case 1: dataGridView1.DataSource = покупателиBindingSource; break;
                case 2: dataGridView1.DataSource = оптовыепокупателиBindingSource; break;
                case 3: dataGridView1.DataSource = продавцыBindingSource; break;
                case 4: dataGridView1.DataSource = сортарастенийBindingSource1; break;
                case 5: dataGridView1.DataSource = новыесортарастенийBindingSource; break;
                case 6: dataGridView1.DataSource = упаковкисемянBindingSource; break;
                case 7: dataGridView1.DataSource = пользователиBindingSource; break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet1.Сорта_растений". При необходимости она может быть перемещена или удалена.
            this.сорта_растенийTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet1.Сорта_растений);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян". При необходимости она может быть перемещена или удалена.
            this.упаковки_семянTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Продажи". При необходимости она может быть перемещена или удалена.
            this.продажиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Продажи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Продавцы". При необходимости она может быть перемещена или удалена.
            this.продавцыTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Продавцы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Оптовые_покупатели". При необходимости она может быть перемещена или удалена.
            this.оптовые_покупателиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Оптовые_покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Новые_сорта_растений". При необходимости она может быть перемещена или удалена.
            this.новые_сорта_растенийTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Новые_сорта_растений);
        }

        int t;
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            tab(0);
            t = 0;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            tab(1);
            t = 1;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            tab(2);
            t = 2;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            tab(3);
            t = 3;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            tab(4);
            t = 4;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tab(5);
            t = 5;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            tab(6);
            t = 6;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            tab(7);
            t = 7;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            switch (t)
            {
                case 0: продажиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Продажи); break;

                case 1: покупателиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Покупатели); break;

                case 2: оптовые_покупателиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Оптовые_покупатели); break;

                case 3: продавцыTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Продавцы); break;

                case 4: сорта_растенийTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet1.Сорта_растений); break;

                case 5: новые_сорта_растенийTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Новые_сорта_растений); break;

                case 6: упаковки_семянTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян); break;

                case 7: пользователиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Пользователи); break;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form2 AvtFrm = new Form2();
            AvtFrm.Show();
            this.Hide();
        }
    }
}
