using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _123301034
{
    class Genetic
    {
        public int Npop;
        public double çaprazlamaoranı;
        public double mutasyonoranı;
        //public int elitnumber;
        public int jenerasyon_sayısı;

        public Genetic(int Npop, int jenerasyon_sayısı,double çaprazlamaoranı,double mutasyonoranı)
        {
            this.Npop = Npop;
            this.çaprazlamaoranı = çaprazlamaoranı;
            this.mutasyonoranı = mutasyonoranı;
            //this.elitnumber = elitnumber;                   //this.elitnumber = Npop * 0.2; olabilir
            this.jenerasyon_sayısı = jenerasyon_sayısı;
        }

        List<Kromozom> popülasyon = new List<Kromozom>();
        List<Kromozom> popülasyon2 = new List<Kromozom>();
        Random rnd = new Random();
        Kromozom k;
        Kromozom child;

        public List<Kromozom> ilkatama()
        {
            for (int i = 0; i < Npop; i++)
            {
                k = new Kromozom();
                for (int j = 0; j < 2; j++)
                {
                    k.Gen[j] = (rnd.NextDouble() * (512 - (-512))) + (-512);
                }
                popülasyon.Add(k);
            }
            return popülasyon;
        }

        public List<Kromozom> sırala()
        {
            popülasyon2.Clear(); 
            popülasyon2.AddRange (from a in popülasyon orderby a.amaç_fonksiyon() where popülasyon2.Count < Npop select a);
            return popülasyon2;
        }
        // eşleşme ve çaprazlama işlemi bu fonksiyonda yapılması planlandı.
        // Seçim işlemi için Sıralama Seçimi Ve Elitizim Birlikte Kullanıldı.
        public List<Kromozom> child_olustur()
        {
            int j = 0;
            double rastgele;
            double rastgele2;
            for (int i = 1; i < popülasyon2.Count; i+=2)
            {
                rastgele2 = rnd.NextDouble();
                if (rastgele2>çaprazlamaoranı)
                {
                    continue;
                }
                child = new Kromozom();
                for (int k = 0; k < 2; k++)
                {
                    rastgele = rnd.NextDouble();
                    child.Gen[k] = (rastgele * popülasyon2[j].Gen[k]) + ((1 - rastgele) * popülasyon2[i].Gen[k]);
                    
                }
                popülasyon2.Add(child);
                j += 2;
            }
            popülasyon.Clear();
            popülasyon = popülasyon2.GetRange(0, popülasyon2.Count);
            popülasyon2 = sırala();
            return popülasyon2;
        }

        // mutasyon işlemi burada yapıldı.
        public List<Kromozom> Mutasyon_işlemi()
        {
            double rastgele;
            for (int i = 0; i < popülasyon2.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    rastgele = rnd.NextDouble();
                    if (rastgele<=mutasyonoranı)
                    {
                        popülasyon2[i].Gen[j] = (rnd.NextDouble() * (512 - (-512))) + (-512);
                    }
                }
            }
            popülasyon.Clear();
            popülasyon = popülasyon2.GetRange(0, popülasyon2.Count);
            popülasyon2 = sırala();
            return popülasyon2;
        }
    }
}
