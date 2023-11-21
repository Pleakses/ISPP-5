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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "попов_СЕ_МДК_01_01DataSet.Сезоны". При необходимости она может быть перемещена или удалена.
            this.сезоныTableAdapter.Fill(this.попов_СЕ_МДК_01_01DataSet.Сезоны);

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

        private void button1_Click(object sender, EventArgs e)
        {
            сезоныTableAdapter.Update(попов_СЕ_МДК_01_01DataSet.Сезоны);
        }
    }
}
