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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "попов_СЕ_МДК_01_01DataSet.Информация_о_туристах". При необходимости она может быть перемещена или удалена.
            this.информация_о_туристахTableAdapter.Fill(this.попов_СЕ_МДК_01_01DataSet.Информация_о_туристах);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "попов_СЕ_МДК_01_01DataSet.Туристы". При необходимости она может быть перемещена или удалена.
            this.туристыTableAdapter.Fill(this.попов_СЕ_МДК_01_01DataSet.Туристы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            туристыTableAdapter.Update(попов_СЕ_МДК_01_01DataSet.Туристы);
            информация_о_туристахTableAdapter.Update(попов_СЕ_МДК_01_01DataSet.Информация_о_туристах);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string a;
        public void st(string s)
        {
            a = s;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 form5 = new Form5();
            form5.Show();
            form5.ii(a);
        }
    }
}
