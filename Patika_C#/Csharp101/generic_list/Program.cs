using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T->object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içinde arama
            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içinde bulundu!");
            }

            //Eleman ile index e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Dizyi listeye çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi temizleme
            hayvanListesi.Clear();

            //Liste içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullancıcı1 = new Kullanıcılar();
            kullancıcı1.Isim = "Ayşe";
            kullancıcı1.Soyisim = "Yılmaz";
            kullancıcı1.Yas = 26;

            Kullanıcılar kullancıcı2 = new Kullanıcılar();
            kullancıcı2.Isim = "Özcan";
            kullancıcı2.Soyisim = "Çalışkan";
            kullancıcı2.Yas = 28;

            kullanıcıListesi.Add(kullancıcı1);
            kullanıcıListesi.Add(kullancıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 23
            });

            foreach (var kullancı in kullanıcıListesi)
            {
                Console.WriteLine("Kullancı Adı: " + kullancı.Isim);
                Console.WriteLine("Kullancı Soyadı: " + kullancı.Soyisim);
                Console.WriteLine("Kullancı Yaşı: " + kullancı.Yas);
            }

        }
    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
