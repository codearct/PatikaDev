using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            //class SinifAdi
            //{
            //      [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //      [Erişim Belirleyici] [Geri Dönüş Tipi] MetodAdi(Parametre Listesi)
            //      {
            //              Metot Komutları
            //      }    
            //}

            //Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected

            Console.WriteLine("---------Çalışan 1---------");
            Calisan calisan1 = new Calisan("Ayşe", "Kara", 234567, "İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("---------Çalışan 2---------");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Mehmet Akif";
            calisan2.Soyad = "Yıldız";
            calisan2.No = 250182;
            calisan2.Departman = "Mimarlık";

            calisan2.CalisanBilgileri();

            Console.WriteLine("---------Çalışan 3---------");
            Calisan calisan3 = new Calisan("Asya", "Kurt");
            calisan3.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public Calisan() { }


        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }
}
