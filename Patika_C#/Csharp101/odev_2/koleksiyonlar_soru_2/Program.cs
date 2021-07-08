using System;

namespace koleksiyonlar_soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen pozitif tamsayı giriniz: ");

            int[] numbers = new int[20];

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
                        numbers[i] = number;
                    }
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Array.Sort(numbers);

            int[] biggestValues = new int[3];
            int[] smallestValues = new int[3];

            int toplamDeger1 = 0;
            int toplamDeger2 = 0;

            for (int i = 0; i < 3; i++)
            {
                smallestValues[i] = numbers[i];
                toplamDeger1 += smallestValues[i];
                biggestValues[i] = numbers[^(i + 1)];
                toplamDeger2 += biggestValues[i];
            }

            double ortDeger1 = (double)toplamDeger1 / smallestValues.Length;
            double ortDeger2 = (double)toplamDeger2 / biggestValues.Length;

            Console.WriteLine("En küçük 3 elemanın ortalamsı: " + ortDeger1);
            Console.WriteLine("en büyük 3 elemanın ortalamsı: " + ortDeger2);
            Console.WriteLine("Ortalamaların Toplamı: " + (ortDeger1 + ortDeger2));


        }
    }
}
