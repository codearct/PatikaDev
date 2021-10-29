using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Kart : IEntity
    {
        public string Baslık { get; set; }
        public string Icerik { get; set; }
        public int Kisi { get; set; }
        public Boyut Buyukluk { get; set; }
    }
}