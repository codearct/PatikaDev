using System;
using System.Collections.Generic;
using DataAcess.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBoardServis
    {
        void Listele();
        void Ekle();
        void Sil();
        void Tasi();

    }
}