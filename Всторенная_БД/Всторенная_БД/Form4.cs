using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Всторенная_БД
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "попов_СЕ_МДК_01_01DataSet.Туры". При необходимости она может быть перемещена или удалена.
            this.турыTableAdapter.Fill(this.попов_СЕ_МДК_01_01DataSet.Туры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "попов_СЕ_МДК_01_01DataSet.Путевки". При необходимости она может быть перемещена или удалена.
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form = new Form2();
            form.Show();
        }
    }
}
