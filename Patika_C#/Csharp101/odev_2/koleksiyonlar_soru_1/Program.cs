using System;
using System.Collections;

namespace koleksiyonlar_soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen pozitif tamsayı giriniz: ");

            ArrayList numbers = new ArrayList();

            try
            {
                for (int i = 0; i < 20; i++)
                {
                    string strNum = Console.ReadLine();

                    int number = Convert.ToInt32(strNum);

                    if (number < 0)
                    {
                        Console.WriteLine("Negatif bir sayı girdiniz!");
                        break;
                    }
                    else
                    {
                        numbers.Add(number);
                    }
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            ArrayList primeNumbers = new ArrayList();
            ArrayList non_PrimeNumbers = new ArrayList();

            foreach (int number in numbers)
            {
                int sayac = 0;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        sayac++;
                    }
                }

                if (sayac == 0)
                {
                    primeNumbers.Add(number);
                }
                else
                {
                    non_PrimeNumbers.Add(number);
                }
            }

            primeNumbers.Sort();
            int toplamDeger = 0;
            Console.WriteLine("Asal sayılar listesi: ");
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                Console.Write(primeNumbers[i] + " ");
                toplamDeger += Convert.ToInt32(primeNumbers[i]);
            }
            double ortalamaDeger = (double)toplamDeger / primeNumbers.Count;
            Console.WriteLine();
            Console.WriteLine("Asal sayı listesinin ortalaması: " + ortalamaDeger);
            Console.WriteLine("Asal sayı listesinin eleman sayısı: " + primeNumbers.Count);

            non_PrimeNumbers.Sort();
            int toplamDeger2 = 0;
            Console.WriteLine("Asal olmayan sayılar listesi: ");
            for (int i = 0; i < non_PrimeNumbers.Count; i++)
            {
                Console.Write(non_PrimeNumbers[i] + " ");
                toplamDeger2 += Convert.ToInt32(non_PrimeNumbers[i]);
            }
            double ortalamaDeger2 = (double)toplamDeger2 / non_PrimeNumbers.Count;
            Console.WriteLine();
            Console.WriteLine("Asal olmayan sayı listesinin ortalaması: " + ortalamaDeger2);
            Console.WriteLine("Asal olmayan sayı listesinin eleman sayısı: " + non_PrimeNumbers.Count);
        }

    }
}
