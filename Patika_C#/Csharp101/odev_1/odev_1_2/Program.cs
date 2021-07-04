using System;

namespace odev_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            try
            {

                Console.WriteLine("Lütfen iki sayı giriniz: ");

                int[] sayiConsole = new int[2];
                for (int i = 0; i < sayiConsole.Length; i++)
                {
                    sayiConsole[i] = Convert.ToInt32(Console.ReadLine());
                }

                int n = sayiConsole[0];
                int m = sayiConsole[1];

                Console.WriteLine("Lütfen {0}.adet sayı giriniz: ", n);

                int[] sayiDizisi = new int[n];
                for (int i = 0; i < n; i++)
                {
                    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("----------{0} sayısına eşit veya tam bölünen sayılar----------", m);

                foreach (int sayi in sayiDizisi)
                {
                    if (sayi == m || sayi % m == 0)
                    {
                        Console.WriteLine(sayi);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
        }
    }
}
