using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace ЛР1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тур_фирмаDataSet2.Все_туристы". При необходимости она может быть перемещена или удалена.
            this.все_туристыTableAdapter.Fill(this.тур_фирмаDataSet2.Все_туристы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тур_фирмаDataSet.Туристы". При необходимости она может быть перемещена или удалена.
            this.туристыTableAdapter.Fill(this.тур_фирмаDataSet.Туристы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тур_фирмаDataSet.Туры". При необходимости она может быть перемещена или удалена.
            this.турыTableAdapter.Fill(this.тур_фирмаDataSet.Туры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тур_фирмаDataSet.Сезоны". При необходимости она может быть перемещена или удалена.
            this.сезоныTableAdapter.Fill(this.тур_фирмаDataSet.Сезоны);
            //toolStripLabel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void qsl(int i)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = тур_фирма; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter[] sa = new SqlDataAdapter[3];
            sa[0] = new SqlDataAdapter("select Фамилия as [ahkfgjah],Имя, Отчество,Серия_паспорта,Город,Страна,Телефон,Индекс from Туристы INNER JOIN [Информация о туристах] ON Туристы.Код_туриста = [Информация о туристах].Код_туриста", sqlConnect);
            sa[1] = new SqlDataAdapter("select Название,Цена,Информация from Туры", sqlConnect);
            sa[2] = new SqlDataAdapter("select Название, Дата_начала, Дата_конца, Сезон_закрыт, Количество_мест from Сезоны INNER JOIN Туры ON Сезоны.Код_тура = Туры.Код_тура", sqlConnect);
            DataSet ds = new DataSet();
            sa[i].Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
         Boolean a = false;
         Boolean b = false;
         Boolean с = false;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }
        int id = 0;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            qsl(0);
            a = true;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            qsl(1);
            b = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.SelectedCells[0].RowIndex.ToString());
            if (a == true)
            {
                toolStripLabel1.Text = "Familia: " + dataGridView1[0, id].Value.ToString() + ", Ima: " + dataGridView1[1, id].Value.ToString() + ", Otchestvo: " + dataGridView1[2, id].Value.ToString();
            }
             if (b == true)
            {
                toolStripLabel1.Text = "Nazvanie: "+ dataGridView1[0, id].Value.ToString() + ", Cena: "+ dataGridView1[1, id].Value.ToString() + ", Informacia: "+ dataGridView1[2, id].Value.ToString();
            }
             if (с == true)
            {
                toolStripLabel1.Text = "Data nachala: " + dataGridView1[1, id].Value.ToString() + ", Data konca: " + dataGridView1[2 ,id].Value.ToString();
            }
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcode = encoder.Encode(toolStripLabel1.Text);
            pictureBox1.Image = qrcode as Image;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            qsl(2);
            с = true;
        }
    }
}
