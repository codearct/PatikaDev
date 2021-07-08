using System;
using System.Collections.Generic;

namespace koleksiyonlar_soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle yazınız: ");

            string cümle = Console.ReadLine();
            char[] harflerCümle = cümle.ToLower().ToCharArray();


            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            List<char> sesliHarfCümle = new List<char>();

            for (int i = 0; i < harflerCümle.Length; i++)
            {
                for (int j = 0; j < sesliHarfler.Length; j++)
                {
                    if (harflerCümle[i] == sesliHarfler[j])
                    {
                        sesliHarfCümle.Add(harflerCümle[i]);
                    }
                }

            }

            sesliHarfCümle.Sort();

            Console.Write("Cümledeki sıralanmış sesli harfler: ");
            foreach (char harf in sesliHarfCümle)
            {
                Console.Write(harf + " ");
            }

        }
    }
}
