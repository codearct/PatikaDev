using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAcess.Abstract;
using DataAcess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BoardManager : IBoardServis
    {
        ToDoKartDal toDoKartDal;
        InProgressKartDal ınProgressKartDal;
        DoneKartDal doneKartDal;

        Kart kart;
        KisiDal kisi;

        public BoardManager()
        {
            toDoKartDal = new ToDoKartDal();
            ınProgressKartDal = new InProgressKartDal();
            doneKartDal = new DoneKartDal();

            kart = new Kart();
            kisi = new KisiDal();

            Console.WriteLine
            (
                "Lütfen yapmak istediğiniz işlemi seçiniz\n" +
                "****************************************\n" +
                "(1) Board Listelemek\n" +
                "(2) Board'a Kart Eklemek\n" +
                "(3) Board'dan Kart Silmek\n" +
                "(4) Kart Taşımak"
            );
            switch (Console.ReadLine())
            {
                case "1":
                    Listele();
                    break;
                case "2":
                    Ekle();
                    break;
                case "3":
                    Sil();
                    break;
                case "4":
                    Tasi();
                    Listele();
                    break;
                default:
                    break;
            }
        }

        public void Listele()
        {
            Console.WriteLine(
                "TODO List\n" +
                "****************************************"
            );

            if (toDoKartDal.Listele().Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var kart in toDoKartDal.Listele())
                {
                    Console.WriteLine("Başlık      :{0}", kart.Baslık);
                    Console.WriteLine("İçerik      :{0}", kart.Icerik);
                    Console.WriteLine("Atanan Kişi :{0}", kart.Kisi);
                    Console.WriteLine("Büyüklük    :{0}", kart.Buyukluk);
                    Console.WriteLine("-");
                }
            }

            Console.WriteLine(
                "IN PROGRESS List\n" +
                "****************************************"
            );

            if (ınProgressKartDal.Listele().Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var kart in ınProgressKartDal.Listele())
                {
                    Console.WriteLine("Başlık      :{0}", kart.Baslık);
                    Console.WriteLine("İçerik      :{0}", kart.Icerik);
                    Console.WriteLine("Atanan Kişi :{0}", kart.Kisi);
                    Console.WriteLine("Büyüklük    :{0}", kart.Buyukluk);
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine(
                "DONE List\n" +
                "****************************************"
            );


            if (doneKartDal.Listele().Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var kart in doneKartDal.Listele())
                {
                    Console.WriteLine("Başlık      :{0}", kart.Baslık);
                    Console.WriteLine("İçerik      :{0}", kart.Icerik);
                    Console.WriteLine("Atanan Kişi :{0}", kart.Kisi);
                    Console.WriteLine("Büyüklük    :{0}", kart.Buyukluk);
                    Console.WriteLine("-");
                }
            }
        }
        public void Ekle()
        {

            Console.Write("Başlık Giriniz                                  :");
            kart.Baslık = Console.ReadLine();

            Console.Write("İçerik Giriniz                                  :");
            kart.Icerik = Console.ReadLine();

            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            kart.Buyukluk = (Boyut)int.Parse(Console.ReadLine());

            Console.Write("Kişi ID Giriniz                                  :");
            kart.Kisi = int.Parse(Console.ReadLine());

            int temp = 0;

            foreach (var uye in kisi.Listele())
            {
                if (uye.Id == kart.Kisi)
                {
                    temp++;
                    toDoKartDal.Ekle(kart);
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Hatalı giriş. Girilen ID'ye ait bir kullanıcı bulunamadı.");
            }
            else
            {
                Console.WriteLine("Kart ekleme gerçekleştirildi.");
            }
        }

        public void Sil()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:");
            string baslik = Console.ReadLine();

            int temp = 0;

            foreach (var item in toDoKartDal.Listele())
            {
                if (item.Baslık == baslik)
                {
                    temp++;
                    toDoKartDal.Sil(item);
                    Console.WriteLine("Silme işlemi gerçekleştirildi.");
                    break;
                }
            }

            foreach (var item in ınProgressKartDal.Listele())
            {
                if (item.Baslık == baslik)
                {
                    temp++;
                    ınProgressKartDal.Sil(item);
                    Console.WriteLine("Silme işlemi gerçekleştirildi.");
                    break;
                }
            }
            foreach (var item in doneKartDal.Listele())
            {
                if (item.Baslık == baslik)
                {
                    temp++;
                    doneKartDal.Sil(item);
                    Console.WriteLine("Silme işlemi gerçekleştirildi.");
                    break;
                }
            }

            if (temp == 0)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                string selected = Console.ReadLine();

                switch (selected)
                {
                    case "1":
                        break;
                    case "2":
                        Sil();
                        break;
                }
            }
        }

        public void Tasi()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:");
            string baslik = Console.ReadLine();

            Console.WriteLine("Bulunan Kart Bilgileri: ");
            Console.WriteLine("**************************************");

            int temp = 0;

            foreach (var item in toDoKartDal.Listele())
            {
                if (item.Baslık == baslik)
                {
                    temp++;
                    Console.WriteLine("Başlık      :{0}", item.Baslık);
                    Console.WriteLine("İçerik      :{0}", item.Icerik);
                    Console.WriteLine("Atanan Kişi :{0}", item.Kisi);
                    Console.WriteLine("Büyüklük    :{0}", item.Buyukluk);
                    Console.WriteLine("Line        :ToDo");

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");

                    string selected = Console.ReadLine();

                    switch (selected)
                    {
                        case "1":
                            Console.WriteLine("Taşımak istediğin kart bu Line'da!");
                            break;
                        case "2":
                            toDoKartDal.Tasi(item, ınProgressKartDal.Listele());
                            Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                            break;
                        case "3":
                            toDoKartDal.Tasi(item, doneKartDal.Listele());
                            Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                            break;
                    }

                }
                break;
            }

            foreach (var item in ınProgressKartDal.Listele())
            {
                if (item.Baslık == baslik && temp == 0)
                {
                    temp++;
                    Console.WriteLine("Başlık      :{0}", item.Baslık);
                    Console.WriteLine("İçerik      :{0}", item.Icerik);
                    Console.WriteLine("Atanan Kişi :{0}", item.Kisi);
                    Console.WriteLine("Büyüklük    :{0}", item.Buyukluk);
                    Console.WriteLine("Line        :InProgress");

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");

                    string selected = Console.ReadLine();

                    switch (selected)
                    {
                        case "1":
                            ınProgressKartDal.Tasi(item, toDoKartDal.Listele());
                            Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                            break;
                        case "2":
                            Console.WriteLine("Taşımak istediğin kart bu Line'da!");
                            break;
                        case "3":
                            ınProgressKartDal.Tasi(item, doneKartDal.Listele());
                            Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                            break;
                    }
                }
                break;
            }
            foreach (var item in doneKartDal.Listele())
            {
                if (item.Baslık == baslik && temp == 0)
                {
                    temp++;
                    Console.WriteLine("Başlık      :{0}", item.Baslık);
                    Console.WriteLine("İçerik      :{0}", item.Icerik);
                    Console.WriteLine("Atanan Kişi :{0}", item.Kisi);
                    Console.WriteLine("Büyüklük    :{0}", item.Buyukluk);
                    Console.WriteLine("Line        :Done");

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");

                    string selected = Console.ReadLine();

                    switch (selected)
                    {
                        case "1":
                            doneKartDal.Tasi(item, toDoKartDal.Listele());
                            Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                            break;
                        case "2":
                            doneKartDal.Tasi(item, ınProgressKartDal.Listele());
                            break;
                        case "3":
                            Console.WriteLine("Taşımak istediğin kart bu Line'da!");
                            break;
                    }
                }
                break;
            }

            if (temp == 0)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Taşıma işlemini sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                string selected = Console.ReadLine();
                switch (selected)
                {
                    case "1":
                        break;
                    case "2":
                        Tasi();
                        break;
                }
            }

        }
    }
}
