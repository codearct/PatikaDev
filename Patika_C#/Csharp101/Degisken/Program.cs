using System;

namespace Degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            byte b = 5;     // 1 byte  0/255 arasi deger alir
            sbyte sb = 5;   // 1 byte -128/127 arasi deger alir

            short s = 5;    // 2 byte  -32768/32768 arasi deger alir
            ushort us = 5;  // 2 byte 0/65365 arasi deger alir

            Int16 i16 = 2;   // 2 byte
            int i = 2;      // 4 byte -2.147.483.648/2.147.483.647 arasi deger alır
            Int32 i32 = 2;  // 4 byte
            Int64 i64 = 2;  // 8 byte

            uint ui = 2;    // 4 byte
            long l = 4;     // 8 byte
            ulong ul = 4;   // 8 byte eksi deger alamiyor

            //Reel sayilar
            float f = 5;    //4 byte
            double d = 5;   // 8 byte
            decimal de = 5;   // 16 byte

            char c = '2';     // 2 byte
            string str = "Akif"; //sinirsiz

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 5;
            object o4 = 2.3;

            //string ifadeler
            string str1 = string.Empty;
            str1 = "Mehmet Akif Yıldız";
            string ad = "Mehmet Akif";
            string soyad = "Yıldız";
            string tamisim = ad + " " + soyad;
            Console.WriteLine(tamisim);

            //integer tanımlamalr

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;
            Console.WriteLine(integer3);

            //boolean ifadeler

            bool bool1 = 10 > 2;

            //Degisken dönüsümleri

            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString();
            Console.WriteLine(yenideger); //Result 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);// Result 40

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22);//Result 40

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);//Result 28.06.2021 why_?

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);





        }
    }
}
