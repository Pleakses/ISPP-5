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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тур_фирмаDataSet3.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.тур_фирмаDataSet3.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тур_фирмаDataSet.Туры". При необходимости она может быть перемещена или удалена.
            this.турыTableAdapter.Fill(this.тур_фирмаDataSet.Туры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тур_фирмаDataSet.Туристы". При необходимости она может быть перемещена или удалена.
            this.туристыTableAdapter.Fill(this.тур_фирмаDataSet.Туристы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тур_фирмаDataSet.Сезоны". При необходимости она может быть перемещена или удалена.
            this.сезоныTableAdapter.Fill(this.тур_фирмаDataSet.Сезоны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тур_фирмаDataSet.Путевка". При необходимости она может быть перемещена или удалена.
            this.путевкаTableAdapter.Fill(this.тур_фирмаDataSet.Путевка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тур_фирмаDataSet.Оплата". При необходимости она может быть перемещена или удалена.
            this.оплатаTableAdapter.Fill(this.тур_фирмаDataSet.Оплата);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тур_фирмаDataSet.Информация_о_туристах". При необходимости она может быть перемещена или удалена.
            this.информация_о_туристахTableAdapter.Fill(this.тур_фирмаDataSet.Информация_о_туристах);

        }
        public int i;

        public void qsl(int i)
        {
            using (SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = тур_фирма; Integrated Security = True"))
            {
                switch (i)
                {
                    case 0:
                        dataGridView1.DataSource = туристыBindingSource;
                        break;
                    case 1:
                        dataGridView1.DataSource = информацияОТуристахBindingSource;
                        break;
                    case 2:
                        dataGridView1.DataSource = турыBindingSource;
                        break;
                    case 3:
                        dataGridView1.DataSource = сезоныBindingSource;
                        break;
                    case 4:
                        dataGridView1.DataSource = оплатаBindingSource;
                        break;
                    case 5:
                        dataGridView1.DataSource = путевкаBindingSource;
                        break;
                    case 6:
                        dataGridView1.DataSource = пользователиBindingSource;
                        break;
                }
                
            }
        }
        
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    туристыTableAdapter.Update(тур_фирмаDataSet.Туристы);
                    break;
                case 1:
                    информация_о_туристахTableAdapter.Update(тур_фирмаDataSet.Информация_о_туристах);
                    break;
                case 2:
                    путевкаTableAdapter.Update(тур_фирмаDataSet.Путевка);
                    break;
                case 3:
                    турыTableAdapter.Update(тур_фирмаDataSet.Туры);
                    break;
                case 4:
                    сезоныTableAdapter.Update(тур_фирмаDataSet.Сезоны); 
                    break;
                case 5:
                    оплатаTableAdapter.Update(тур_фирмаDataSet.Оплата);
                    break;
                case 6:
                    пользователиTableAdapter.Update(тур_фирмаDataSet3.Пользователи);
                    break;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Hide();
            f2.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            i = 0;
            qsl(i);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            i = 1;
            qsl(i);
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            i = 2;
            qsl(i);
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            i = 3;
            qsl(i);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            i = 4;
            qsl(i);
        } 
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            i = 5;
            qsl(i);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            i = 6;
            qsl(i);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
