
using System;
using System.Collections.Generic;
using DataAcess.Abstract;
using Entities.Concrete;

namespace DataAcess.Concrete
{
    public class ToDoKartDal : IKartDal
    {
        List<Kart> ToDoList;
        public ToDoKartDal()
        {
            //KisiDal _takim = new KisiDal();

            ToDoList = new List<Kart>
            {
                new Kart{
                    Baslık="Konut",
                    Icerik="SM_Evi",
                    Kisi=1,
                    Buyukluk=Boyut.S
                },
                new Kart{
                    Baslık="Ticaret",
                    Icerik="Saglam_Is_Merkezi",
                    Kisi=3,
                    Buyukluk=Boyut.L
                }
            };
        }

        public List<Kart> Listele()
        {
            return ToDoList;
        }
        public void Ekle(Kart kart)
        {
            ToDoList.Add(kart);
        }

        public void Sil(Kart kart)
        {
            ToDoList.Remove(kart);
        }

        public void Tasi(Kart kart, List<Kart> newList)
        {
            newList.Add(kart);
            Sil(kart);
        }
    }
}