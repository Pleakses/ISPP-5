using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Охрана_квартир
{
    public partial class Администратор : Form
    {
        public Администратор()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ_01_Неверов_ДСDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.уП_ПМ_01_Неверов_ДСDataSet.User);
            ToolTip tt = new ToolTip();
            tt.SetToolTip(textBox1, "Введите значение, которое хотите найти в таблице") ;
        }
        public int i;
        public void table (int i)
        {
            using (SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = УП_ПМ_01_Неверов_ДС; Integrated Security = True"))
            {
                switch (i)
                {
                    case 0:
                        dataGridView1.DataSource = userBindingSource;
                        break;
                }
            }

        }
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Авторизация ав = new Авторизация();
            Hide();
            ав.Show();
        }

        private void выйтиИзПриложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripTextBox1_MouseHover(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.RowCount;
            int index = dataGridView1.CurrentRow.Index;
            if (index < i)
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, index + 1];
            }
            if (index == i)
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, 0];
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i = 0;
            table(i);
        }
    }
}
