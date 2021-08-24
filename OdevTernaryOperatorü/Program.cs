using System;

namespace OdevTernaryOperatorü
{
    class Program
    {
        static void Main(string[] args)
        {
            //TernaryOperatorü kullanımı bu şekilde.
            bool medenihal = true;
            string mesaj = medenihal == true ? "Evlilere kampanya..." : "Bekarlara Kampanya";
            Console.WriteLine(mesaj);

            Console.ReadKey();
        }
    }
}
