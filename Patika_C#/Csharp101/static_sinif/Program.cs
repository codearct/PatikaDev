using System;

namespace static_sinif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe", "Yılmaz", "İK");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Deniz", "Arda", "IT");
            Calisan calisan2 = new Calisan("Asya", "Kurt", "İK");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            //Islemler islemler=new Islemler();
            //islemler.  //erişilemez çünkü bütün metotlar static sınıf üzerinden erişilebilir.

            Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(100, 200));
            Console.WriteLine("Çıkarma işlemi sonucu: {0}", Islemler.Cikar(400, 50));


        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
