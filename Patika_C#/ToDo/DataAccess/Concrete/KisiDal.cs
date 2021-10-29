using System;
using System.Collections.Generic;
using DataAcess.Abstract;
using Entities.Concrete;

namespace DataAcess.Concrete
{
    public class KisiDal : IKisiDal
    {
        List<Kisi> Takim;
        public KisiDal()
        {
            Takim = new List<Kisi>{
                new Kisi{Id=1,Ad="Ayşe",Soyad="Yılmaz"},
                new Kisi{Id=2,Ad="İsmail",Soyad="Efe"},
                new Kisi{Id=3,Ad="Salih",Soyad="Kapuz"},
                new Kisi{Id=4,Ad="Asya",Soyad="Yılmaz"},
                new Kisi{Id=5,Ad="Ahmet",Soyad="Okyay"}
            };
        }

        public List<Kisi> Listele()
        {
            return Takim;
        }
    }
}