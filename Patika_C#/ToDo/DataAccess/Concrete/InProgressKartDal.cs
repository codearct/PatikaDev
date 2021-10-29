using System;
using System.Collections.Generic;
using DataAcess.Abstract;
using Entities.Concrete;

namespace DataAcess.Concrete
{
    public class InProgressKartDal : IKartDal
    {
        List<Kart> InProgressList;
        public InProgressKartDal()
        {
            InProgressList = new List<Kart>
            {
                new Kart{
                    Baslık="Eğitim",
                    Icerik="Atatürk_İlkokulu",
                    Kisi=4,
                    Buyukluk=Boyut.M
                }
            };
        }

        public List<Kart> Listele()
        {
            return InProgressList;
        }
        public void Ekle(Kart kart)
        {
            InProgressList.Add(kart);
        }


        public void Sil(Kart kart)
        {
            InProgressList.Remove(kart);
        }

        public void Tasi(Kart kart, List<Kart> newList)
        {
            newList.Add(kart);
            Sil(kart);
        }
    }
}