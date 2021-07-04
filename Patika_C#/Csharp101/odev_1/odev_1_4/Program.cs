using System;

namespace odev_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.Write("Lütfen bir cümle yazınız: ");
            string cümle = Console.ReadLine();

            string[] kelimeDizisi = cümle.Split(" ");
            int kelimesayisi = kelimeDizisi.Length;

            string harfDizisi = string.Join("", kelimeDizisi);

            char[] harf = harfDizisi.ToCharArray();
            int harfsayisi = harf.Length;

            Console.WriteLine("----------Girilen Cümlenin Öğeleri----------");
            Console.WriteLine("Girdiğiniz cümledeki kelime sayısı: {0}", kelimesayisi);
            Console.WriteLine("Girdiğiniz cümledeki harf sayısı: {0}", harfsayisi);



        }
    }
}
