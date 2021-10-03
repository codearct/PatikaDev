
using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace DataAcess.Abstract
{
    public interface IKartDal
    {
        List<Kart> Listele();
        void Ekle(Kart kart);
        void Sil(Kart kart);
        void Tasi(Kart kart, List<Kart> newList);

    }
}