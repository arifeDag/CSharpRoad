using System;

namespace TemelKavramlar
{
    class Program
    {

        static string degisken1 = "Bu bir global Degisken";

        static void Main(string[] args)
        {

            string degisken2 = "bu bir local degisken, method";

            Console.WriteLine("merhaba Dünya");

            Console.WriteLine(degisken1);

            Console.WriteLine(degisken2);

            for (int i = 0; i < 10; i++)
            {
                string degisken3 = $"Bu bir local degisken, dongü {i}";

                Console.WriteLine(degisken3);
                
            }


        }
    }
}
