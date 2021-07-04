using System;

namespace odev_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            try
            {
                Console.Write("Lütfen bir sayı giriniz: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen {0} adet kelime giriniz: ", n);

                string[] kelimeDizisi = new string[n];
                for (int i = 0; i < n; i++)
                {
                    kelimeDizisi[i] = Console.ReadLine();
                }

                Array.Reverse(kelimeDizisi);

                Console.WriteLine("----------Sondan Başa Doğru Girdiğin Kelimeler----------");
                foreach (string kelime in kelimeDizisi)
                {
                    Console.WriteLine(kelime);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }


        }
    }
}
