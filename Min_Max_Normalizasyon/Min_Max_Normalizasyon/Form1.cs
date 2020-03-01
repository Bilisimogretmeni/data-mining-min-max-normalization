using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Min_Max_Normalizasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<int> sayiDizisi = new List<int>();
        //Sayıların tutulacağı liste

        private void button1_Click(object sender, EventArgs e)//Rastgele sayı oluşturma ve listeye atama işlemi
        {
            int aralik = Convert.ToInt32(textBox1.Text);
            Random Rand = new Random();
            int sayi = 0;
            listBox1.Items.Clear();
            sayiDizisi.Clear();
            for (int i = 1; i < 15; i++)
            {
                sayi = Rand.Next(aralik);
                listBox1.Items.Add(sayi);
                sayiDizisi.Add(sayi);
            }
        }

        private void button2_Click(object sender, EventArgs e)//Listeden her elemanın minmaxnormalizasyon fonk.ile hesaplanması
        {
            listView1.Items.Clear();
            foreach(double i in sayiDizisi)
            {
                ListViewItem liste = new ListViewItem();
                liste.Text = i.ToString();
                liste.SubItems.Add(minmaxnormalizasyon(i).ToString("0.###"));
                listView1.Items.Add(liste);
            }            
        }
        double minmaxnormalizasyon(double sayi)
        {
            double deger = (sayi - sayiDizisi.Min()) / (sayiDizisi.Max() - sayiDizisi.Min());
           
            return deger;
        }
    }
}
