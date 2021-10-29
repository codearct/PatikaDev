using System;

namespace odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            try
            {
                Console.Write("Pozitif bir sayı giriniz: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen {0} adet sayı giriniz: ", n);

                int[] sayiDizisi = new int[n];

                for (int i = 0; i < n; i++)
                {
                    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());

                    if (sayiDizisi[i] < 0)
                    {
                        Console.WriteLine("Negatif bir sayı girdiniz.Tekrar Deneyin!!!");
                        break;
                    }
                }

                Console.WriteLine("----------Çift Sayılar----------");

                foreach (int sayi in sayiDizisi)
                {
                    if (sayi < 0)
                    {
                        break;
                    }

                    else if (sayi % 2 == 0)
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
