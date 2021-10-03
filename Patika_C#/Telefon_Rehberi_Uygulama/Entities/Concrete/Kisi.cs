using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Kisi : IKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelNo { get; set; }

    }

}