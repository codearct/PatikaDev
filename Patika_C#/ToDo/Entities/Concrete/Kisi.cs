using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Kisi : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}