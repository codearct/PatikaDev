using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace DataAcess.Abstract
{
    public interface IKisiDal
    {
        void Listele();
        void Ekle(Kisi kisi);
        void Güncelle(Kisi kisi);
        void Sil(Kisi kisi);
        void Ara();

    }
}