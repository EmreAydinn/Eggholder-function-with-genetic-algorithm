using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace _123301034
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Genetic g1;
        List<Kromozom> popülasyon = new List<Kromozom>();
        Random rnd = new Random();

        public void listboxlara_yaz(ListBox b)
        {
            b.Items.Clear();
            b.Items.Add(popülasyon.Count.ToString());
            foreach (var kr in popülasyon)
            {
                b.Items.Add("kromozom " + kr.amaç_fonksiyon() + "\r\n");
                for (int i = 0; i < 2; i++)
                {
                    b.Items.Add(kr.Gen[i].ToString() + "\r\n");
                }
            }
        }
        private void buttonbasla_Click(object sender, EventArgs e)
        {
           
            g1 = new Genetic((int)numericUpDownnpop.Value, (int)numericUpDownjenerasyon_sayısı.Value,(double)numericUpDowncaprazlama.Value,(double)numericUpDownmutasyon_oranı.Value);

            popülasyon = g1.ilkatama();
            listboxlara_yaz(listBox1);       // ilk atanan değerler ekrana yazıldı. 
           
            popülasyon = g1.sırala();
            listboxlara_yaz(listBox2);     // en iyi 100 değer seçilerek ekrana yazıldı.

            for (int i = 0; i <= (int)numericUpDownjenerasyon_sayısı.Value; i++)
            {
                popülasyon = g1.child_olustur();
                if (i == g1.jenerasyon_sayısı)
                {
                    listboxlara_yaz(listBox3);      // çaprazlama sonuçları ekrana yazıldı.
                }
                popülasyon = g1.Mutasyon_işlemi();
                if (i == g1.jenerasyon_sayısı)
                {
                    listboxlara_yaz(listBox4);      // mutasyon sonuçları ekrana yazıldı.
                }
                
            }

            //chart1.Titles.Clear();
            //chart1.Series.Clear();

            //chart1.Series.Add("EGGHOLDER FUNCTION");

            chart1.Series["EGGHOLDER FUNCTION"].Points.Clear();

            for (int i = 0; i < popülasyon.Count; i++)
            {
                chart1.Series["EGGHOLDER FUNCTION"].Points.AddXY(i.ToString(),(popülasyon[i].amaç_fonksiyon()));
            }
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
