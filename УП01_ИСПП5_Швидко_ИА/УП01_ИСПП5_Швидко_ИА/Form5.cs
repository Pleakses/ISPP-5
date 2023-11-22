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
using УП01_ИСПП5_Швидко_ИА.УП01_ИСПП5_Швидко_ИАDataSetTableAdapters;

namespace УП01_ИСПП5_Швидко_ИА
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public void Tub(int i)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Швидко_ИА; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter[] so = new SqlDataAdapter[7];
            so[0] = new SqlDataAdapter("select * from Продажи", sqlConnect);
            so[1] = new SqlDataAdapter("select * from Покупатели", sqlConnect);
            so[2] = new SqlDataAdapter("select * from Оптовые_покупатели", sqlConnect);
            so[3] = new SqlDataAdapter("select * from Продавцы", sqlConnect);
            so[4] = new SqlDataAdapter("select * from Сорта_растений", sqlConnect);
            so[5] = new SqlDataAdapter("select * from Новые_сорта_растений", sqlConnect);
            so[6] = new SqlDataAdapter("select * from Упаковки_семян", sqlConnect);
            DataSet ps = new DataSet();
            so[i].Fill(ps);
            dataGridView1.DataSource = ps.Tables[0];
        }
        public Boolean a = false;
        public Boolean b = false;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 AvtFrm = new Form2();
            AvtFrm.Show();
            this.Hide();
        }
        int t;
        private void toolStripButton3_Click(object sender, EventArgs e)
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

            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Tub(0);
            t = 0;
            a = true;
            dataGridView1.ReadOnly = false;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Tub(1);
            t = 1;
            a = true;
            dataGridView1.ReadOnly = false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Tub(2);
            t = 2;
            a = true;
            dataGridView1.ReadOnly = false;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Tub(3);
            t = 3;
            a = true;
            dataGridView1.ReadOnly = true;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Tub(4);
            t = 4;
            a = true;
            dataGridView1.ReadOnly = true;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            Tub(5);
            t = 5;
            a = true;
            dataGridView1.ReadOnly = true;
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            Tub(6);
            t = 6;
            a = true;
            dataGridView1.ReadOnly = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet1.Сорта_растений". При необходимости она может быть перемещена или удалена.
            this.сорта_растенийTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet1.Сорта_растений);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян". При необходимости она может быть перемещена или удалена.
            this.упаковки_семянTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Продажи". При необходимости она может быть перемещена или удалена.
            this.продажиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Продажи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Продавцы". При необходимости она может быть перемещена или удалена.
            this.продавцыTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Продавцы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Оптовые_покупатели". При необходимости она может быть перемещена или удалена.
            this.оптовые_покупателиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Оптовые_покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Новые_сорта_растений". При необходимости она может быть перемещена или удалена.
            this.новые_сорта_растенийTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Новые_сорта_растений);

        }
    }
}
