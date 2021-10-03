using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace DataAcess.Abstract
{
    public interface IKisiDal
    {
        List<Kisi> Listele();
    }
}