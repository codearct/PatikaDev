using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //                            Canlılar
            //                                |
            //             Bitkiler                        Hayvanlar
            //       |                  |           |                   |
            //     Tohumlu           Tohumsuz    Sürüngenler           Kuşlar


            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
            //tohumluBitkiler.Beslenme();//canlılar sınıfından kalıtım
            //tohumluBitkiler.Solunum();//canlılar sınıfından kalıtım
            //tohumluBitkiler.Bosaltim();//canlılar sınıfından kalıtım
            //tohumluBitkiler.Fotosentez();//bitkiler sınıfından kalıtım
            tohumluBitkiler.TohumlaCogalma();//kendi sınıf metotu

            Console.WriteLine("---------------------");

            Kuslar martı = new Kuslar();
            //martı.Beslenme();//canlılar sınıfından kalıtım
            //martı.Solunum();//canlılar sınıfından kalıtım
            //martı.Bosaltim();//canlılar sınıfından kalıtım
            //martı.Adaptasyon();//hayvanlar sınıfından kalıtım
            martı.Ucmak();//kendi sınıf metotu
        }
    }
}
