using System;
using System.Collections.Generic;
using DataAcess.Abstract;
using Entities.Concrete;

namespace DataAcess.Concrete
{

    public class KisiDal : IKisiDal
    {
        List<Kisi> _kisiler;
        public KisiDal()
        {
            _kisiler = new List<Kisi>{
                new Kisi{Ad="Ayşe",Soyad="Yılmaz",TelNo="5448231759"},
                new Kisi{Ad="İsmail",Soyad="Efe",TelNo="5327265422"},
                new Kisi{Ad="Salih",Soyad="Kapuz",TelNo="5324786129"},
                new Kisi{Ad="Asya",Soyad="Yılmaz",TelNo="5362148952"},
                new Kisi{Ad="Ahmet",Soyad="Okyay",TelNo="5336251784"}
            };

        }

        public void Ekle(Kisi kisi)
        {
            Console.Write("Lütfen isim giriniz             :");
            kisi.Ad = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          :");
            kisi.Soyad = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz :");
            kisi.TelNo = Console.ReadLine();
            _kisiler.Add(kisi);
        }

        public void Güncelle(Kisi kisi)
        {
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");

            string ad_soyad = Console.ReadLine();

            foreach (var k in _kisiler)
            {
                if (ad_soyad == k.Ad || ad_soyad == k.Soyad)
                {
                    kisi = k;
                }
                else
                {
                    Console.WriteLine
                    (
                        "Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
                        "* Güncellemeyi sonlandırmak için : (1)\n" +
                        "* Yeniden denemek için      : (2)"
                    );
                    switch (Console.ReadLine())
                    {
                        case "1":
                            break;
                        case "2":
                            Sil(new Kisi());
                            break;
                    }
                }
                break;
            }
            Console.Write("Lütfen {0} {1} isimli kişinin yeni numarasını giriniz:");
            kisi.TelNo = Console.ReadLine();

        }

        public void Listele()
        {
            Console.WriteLine("Telefon Rehberi\n" + "**********************************************");
            foreach (var k in _kisiler)
            {
                Console.WriteLine("isim: {0}", k.Ad);
                Console.WriteLine("Soyisim: {0}", k.Soyad);
                Console.WriteLine("Telefon Numarası: {0}", k.TelNo);
                Console.WriteLine("-");
            }
        }

        public void Sil(Kisi kisi)
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");

            string ad_soyad = Console.ReadLine();

            foreach (var k in _kisiler)
            {
                if (ad_soyad == k.Ad || ad_soyad == k.Soyad)
                {
                    Console.WriteLine("{0} {1} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", k.Ad, k.Soyad);
                    switch (Console.ReadLine())
                    {
                        case "y":
                            kisi = k;
                            break;
                        case "n":
                            break;
                    }
                }
                else
                {
                    Console.WriteLine
                    (
                        "Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
                        "* Silmeyi sonlandırmak için : (1)\n" +
                        "* Yeniden denemek için      : (2)"
                    );
                    switch (Console.ReadLine())
                    {
                        case "1":
                            break;
                        case "2":
                            Sil(new Kisi());
                            break;
                    }
                }
                break;
            }

            _kisiler.Remove(kisi);
        }

        public void Ara()
        {
            List<Kisi> aranan = new List<Kisi>();

            Console.WriteLine
            (
                "Arama yapmak istediğiniz tipi seçiniz.\n" +
                "**********************************************\n" +
                "\n" +
                "İsim veya soyisime göre arama yapmak için: (1)\n" +
                "Telefon numarasına göre arama yapmak için: (2)"
            );
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Lütfen aramak istediğiniz kişinin adını ya da soyadını giriniz:");
                    string ad_soyad = Console.ReadLine();
                    foreach (var k in _kisiler)
                    {
                        if (ad_soyad == k.Ad || ad_soyad == k.Soyad)
                        {
                            aranan.Add(k);
                        }
                    }
                    break;

                case "2":
                    Console.Write("Lütfen aramak istediğiniz kişinin telefon numarasını giriniz:");
                    string telNo = Console.ReadLine();
                    foreach (var k in _kisiler)
                    {
                        if (telNo == k.TelNo)
                        {
                            aranan.Add(k);
                        }
                    }
                    break;
            }
            Console.WriteLine("Arama Sonuçlarınız:\n" + "**********************************************");
            foreach (var k in aranan)
            {
                Console.WriteLine("isim: {0}", k.Ad);
                Console.WriteLine("Soyisim: {0}", k.Soyad);
                Console.WriteLine("Telefon Numarası: {0}", k.TelNo);
                Console.WriteLine("-");
            }
        }
    }
}