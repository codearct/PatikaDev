using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRehberServis
    {
        void Listele();
        void Ekle(Kisi kisi);
        void Sil(Kisi kisi);
        void Güncelle(Kisi kisi);
        void Ara();

    }
}