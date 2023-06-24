using System;

namespace TemelVeriYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "yavuz";
            string soyısım = "kara";

            int x = 17;
            int y = 25;

            int sonuc = x + y;

            uint z = 0;
            uint v = 4000;

            short b = -200;
            short c = 200;

            ushort k =65000;
            ushort t=0;

            byte f =255;
            Console.WriteLine("String");

            Console.WriteLine(ad);
            Console.WriteLine(soyısım);

            Console.WriteLine("Integer");
            Console.WriteLine(sonuc);

            Console.WriteLine("uint");
            Console.WriteLine(z);
            Console.WriteLine(v);


            Console.WriteLine("short");
            Console.WriteLine(b);
            Console.WriteLine(c);


            Console.WriteLine("ushort");
            Console.WriteLine(k);
            Console.WriteLine(t);

            Console.WriteLine("byte");
            Console.WriteLine(f);
        }
    }
}
