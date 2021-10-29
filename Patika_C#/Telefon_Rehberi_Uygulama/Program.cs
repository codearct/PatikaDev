using System;
using Business.Concrete;
using DataAcess.Concrete;

namespace Telefon_Rehberi_Uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            RehberManager rehberManager = new RehberManager(new KisiDal());
        }
    }
}
