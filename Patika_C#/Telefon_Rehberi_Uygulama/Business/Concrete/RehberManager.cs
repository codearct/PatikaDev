using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAcess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RehberManager : IRehberServis
    {
        IKisiDal _kisiDal;
        public RehberManager(IKisiDal kisiDal)
        {
            _kisiDal = kisiDal;

            Console.WriteLine
            (
                "Lütfen yapmak istediğiniz işlemi seçiniz\n" +
                "****************************************\n" +
                "(1) Yeni Numara Kaydetmek\n" +
                "(2) Varolan Numarayı Silmek\n" +
                "(3) Varolan Numarayı Güncelleme\n" +
                "(4) Rehberi Listelemek\n" +
                "(5) Rehberde Arama Yapmak"
            );

            switch (Console.ReadLine())
            {
                case "1":
                    Ekle(new Kisi());
                    break;
                case "2":
                    Sil(new Kisi());
                    break;
                case "3":
                    Güncelle(new Kisi());
                    break;
                case "4":
                    Listele();
                    break;
                case "5":
                    Ara();
                    break;
                default:
                    break;
            }

        }

        public void Ara()
        {
            _kisiDal.Ara();
        }

        public void Ekle(Kisi kisi)
        {
            _kisiDal.Ekle(kisi);
        }

        public void Güncelle(Kisi kisi)
        {
            _kisiDal.Güncelle(kisi);
        }

        public void Listele()
        {
            _kisiDal.Listele();
        }

        public void Sil(Kisi kisi)
        {
            _kisiDal.Sil(kisi);
        }
    }
}