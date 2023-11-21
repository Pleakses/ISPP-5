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
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;


namespace Всторенная_БД
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        
        int i = 0;
        private void Form11_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "попов_СЕ_МДК_01_01DataSet.Туристы". При необходимости она может быть перемещена или удалена.
            this.туристыTableAdapter.Fill(this.попов_СЕ_МДК_01_01DataSet.Туристы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "попов_СЕ_МДК_01_01DataSet.Информация_о_туристах". При необходимости она может быть перемещена или удалена.
            this.информация_о_туристахTableAdapter.Fill(this.попов_СЕ_МДК_01_01DataSet.Информация_о_туристах);
            sel();
        }
        string poisk = "", sort = "";
        public void sel()
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = попов_СЕ_МДК_01_01; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter[] da = new SqlDataAdapter[5];
            if (comboBox1.Text == "Возрастание")
            {
                sort = "Order by Фамилия desc";
            }
            else if (comboBox1.Text == "Убывание")
            {
                sort = "Order by Фамилия asc";
            }
            da[0] = new SqlDataAdapter($"select Фамилия,Имя,Отчество,[Серия паспорта], Город, Страна, Индекс from Туристы join [Информация о туристах] on Туристы.[Код туриста] = [Информация о туристах].[Код туриста]", sqlConnect);
            da[1] = new SqlDataAdapter($"select Название,Цена,Информация,[Дата начала], [Дата конца], [Сезон закрыт] from Туры join Сезоны on Туры.[Код тура] = Сезоны.[Код тура]", sqlConnect);
            da[2] = new SqlDataAdapter($"select Фамилия,Имя,Отчество,[Серия паспорта], Город, Страна, Индекс, Название as [Название тура],Цена,Информация as [Информация о туре],[Дата начала] as [Дата начала сезона], [Дата конца] as [Дата конца сезона], [Сезон закрыт]from (Путевки join  (Туристы join [Информация о туристах] on Туристы.[Код туриста] = [Информация о туристах].[Код туриста]) on Путевки.[Код туриста] = [Информация о туристах].[Код туриста])  join (Туры join Сезоны on Туры.[Код тура] = Сезоны.[Код тура]) on Путевки.[Код сезона] = Сезоны.[Код сезона]", sqlConnect);
            da[3] = new SqlDataAdapter($"select Фамилия,Имя,Отчество,[Серия паспорта], Город, Страна, Индекс, Название as [Название тура],Цена,Информация as [Информация о туре],[Дата начала] as [Дата начала сезона], [Дата конца] as [Дата конца сезона], [Сезон закрыт],[Дата оплаты], Сумма as [Сумма оплаты] from Оплата  join((Путевки join  (Туристы join [Информация о туристах] on Туристы.[Код туриста] = [Информация о туристах].[Код туриста]) on Путевки.[Код туриста] = [Информация о туристах].[Код туриста])  join (Туры join Сезоны on Туры.[Код тура] = Сезоны.[Код тура]) on Путевки.[Код сезона] = Сезоны.[Код сезона]) on Оплата.[Код путевки] = Путевки.[Код путевки]", sqlConnect);
            da[4] = new SqlDataAdapter($"select Фамилия,Имя,Отчество,[Серия паспорта], Город, Страна, Индекс from Туристы join [Информация о туристах] on Туристы.[Код туриста] = [Информация о туристах].[Код туриста] where Фамилия Like '{poisk}%' {sort}",sqlConnect);
            DataSet ds = new DataSet();
            da[i].Fill(ds);
            
            if (i == 4)
            {
                button1.Location = new Point(12, 224);
                button2.Location = new Point(303, 224);
                button3.Location = new Point(158, 253);
                Size = new Size(617, 325);
                label1.Visible = true;
                textBox1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                checkBox1.Visible = true;
                comboBox1.Visible = false;
                pictureBox1.Visible = false;
                if (checkBox1.Checked == true)
                {
                    label1.Text = "Сортировка по:";
                    textBox1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    comboBox1.Visible = true;
                    Text = "Сортировка";
                }
                else
                {
                    label1.Text = "Поиск по Фамилии:";
                    textBox1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    comboBox1.Visible = false;
                    Text = "Поиск по фамилии";
                }
            }
            else
            {
                button1.Location = new Point(12, 184);
                button2.Location = new Point(303, 184);
                button3.Location = new Point(158, 213);
                Size = new Size(617, 282);
                label1.Visible = false;
                textBox1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                checkBox1.Visible = false;
                comboBox1.Visible = false;
                pictureBox1.Visible = false;
            }
            if (i == 2)
            {
                Size = new Size(805, 325);
                pictureBox1.Visible = true;

            }
            dataGridView1.DataSource = ds.Tables[0];
            switch (i)
            {
                case 0: Text = "Туристы + Информация о туристах";break;
                case 1: Text = "... + Сезоны"; break;
                case 2: Text = "... +  Путевки"; break;
                case 3: Text = "... + Оплата"; break;
                case 4: Text = "Поиск по фамилии";break;
                default: MessageBox.Show("Ошибка");break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            {
                i = 4;
            }
            sel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            if (i > 4)
            {
                i = 0;
            }
            sel();
        }
        string a;
        public void st(string s)
        {
            a = s;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 form5 = new Form5();
            form5.Show();
            form5.ii(a);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                poisk = textBox1.Text;
                sel();
            }
        }
        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            sel();
        }
        int index = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = int.Parse(dataGridView1.SelectedCells[0].RowIndex.ToString());
            textBox2.Text = $"{dataGridView1[0, index].Value}|{dataGridView1[1, index].Value}|{dataGridView1[5, index].Value}|{dataGridView1[10, index].Value}|{dataGridView1[11, index].Value}|{dataGridView1[6, index].Value}";
            var translation = new Dictionary<char, string>()
        {
        {'а',"a"},
        {'б',"b"},
        {'в',"v"},
        {'г',"g"},
        {'д',"d"},
        {'е',"e"},
        {'ж',"sh"},
        {'з',"z"},
        {'и',"i"},
        {'й',"i"},
        {'ё',"e"},
        {'к',"k"},
        {'л',"l"},
        {'м',"m"},
        {'н',"n"},
        {'о',"o"},
        {'п',"p"},
        {'р',"r"},
        {'с',"s"},
        {'т',"t"},
        {'у',"y"},
        {'ф',"f"},
        {'х',"x"},
        {'ц',"c"},
        {'ч',"ch"},
        {'ш',"sh"},
        {'щ',"sh'"},
        {'ъ',""},
        {'ы',"i"},
        {'ь',"'"},
        {'э',"ae"},
        {'ю',"iy"},
        {'я',"ia"},
        {'А',"A"},
        {'Б',"B"},
        {'В',"V"},
        {'Г',"G"},
        {'Д',"D"},
        {'Е',"E"},
        {'Ж',"SH"},
        {'З',"Z"},
        {'И',"I"},
        {'Й',"I"},
        {'Ё',"E"},
        {'К',"K"},
        {'Л',"L"},
        {'М',"M"},
        {'Н',"N"},
        {'О',"O"},
        {'П',"P"},
        {'Р',"R"},
        {'С',"S"},
        {'Т',"T"},
        {'У',"Y"},
        {'Ф',"F"},
        {'Х',"X"},
        {'Ц',"C"},
        {'Ч',"CH"},
        {'Ш',"SH"},
        {'Щ',"SH'"},
        {'Ъ',""},
        {'Ы',"I"},
        {'Ь',"'"},
        {'Э',"AE"},
        {'Ю',"IY"},
        {'Я',"IA"}
        };
            for (int i = 0; i < translation.Count; i++)
            {
                textBox2.Text = textBox2.Text.Replace(translation.ElementAt(i).Key.ToString(), translation.ElementAt(i).Value);
            }
            textBox2.Text = textBox2.Text.Replace(" 0:00:00", "");
            try
            {
                QRCodeEncoder encoder = new QRCodeEncoder();
                Bitmap qr = encoder.Encode(textBox2.Text);
                pictureBox1.Image = qr as Image;
            }
            catch
            {

            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sel();
        }
    }
}
