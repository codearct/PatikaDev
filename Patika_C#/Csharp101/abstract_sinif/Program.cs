using System;

namespace abstract_sinif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------");

            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkanınAracı().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Console.WriteLine("-------------------");

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkanınAracı().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());

            Console.WriteLine("-------------------");

            NewFocus focus1 = new NewFocus();
            Console.WriteLine(focus1.HangiMarkanınAracı().ToString());
            Console.WriteLine(focus1.KacTekerlektenOlusur());
            Console.WriteLine(focus1.StandartRengiNe().ToString());

            Console.WriteLine("-------------------");

            NewCivic civic1 = new NewCivic();
            Console.WriteLine(civic1.HangiMarkanınAracı().ToString());
            Console.WriteLine(civic1.KacTekerlektenOlusur());
            Console.WriteLine(civic1.StandartRengiNe().ToString());
        }
    }
}
