using System;

namespace Kamp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double DolarDun = 7.35;
            Double DolarBugun = 7.45;

            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("Dolar Dün daha yüksek");
            }
            else
            {
                Console.WriteLine("Dolar Bugün daha yüksek");
            }
            Console.ReadKey();
        }
    }
}
