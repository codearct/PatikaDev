using System;

namespace polymorphism
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir.");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar.");

        }
        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım yapar.");
        }
        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }

    }
}