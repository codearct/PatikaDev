using System;
using System.Collections.Generic;
using DataAcess.Abstract;
using Entities.Concrete;

namespace DataAcess.Concrete
{
    public class DoneKartDal : IKartDal
    {
        List<Kart> DoneList;
        public DoneKartDal()
        {
            DoneList = new List<Kart> { };
        }

        public List<Kart> Listele()
        {
            return DoneList;
        }
        public void Ekle(Kart kart)
        {
            DoneList.Add(kart);
        }


        public void Sil(Kart kart)
        {
            DoneList.Remove(kart);
        }

        public void Tasi(Kart kart, List<Kart> newList)
        {
            newList.Add(kart);
            Sil(kart);
        }
    }
}