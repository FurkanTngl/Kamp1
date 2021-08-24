using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlama Başlangıç için temel kurs";
            string Kurs3 = "Java";

            //uzun uzun uğraşmak istemiyoruz Do Not Repeat Yourself!
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(Kurs3);

            //Dizi Tanımlama, Tek tek tanımlamak yerine Bunu bir listede tuttuk.
            string[] Kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
            "Programlama Başlangıç için temel kurs",
            "Java","Python","C#" };

            //(Kurslar.Length) Dizinin uzunluğuna göre listeler ister 5 ister 10 tane ürünümüz olsun. 
            //Console.WriteLine(Kurslar[i]) Kursların i'nci elemanı diyoruz.
            for (int i = 0; i < Kurslar.Length; i++)
            {
                Console.WriteLine(Kurslar[i]);
            }
            Console.WriteLine("For bitti.");

            //Kursları tek tek dolaş.(Foreach dizilere uygulanır.)
            foreach (string xyz in Kurslar)
            {
                Console.WriteLine(xyz);
            }

            Console.WriteLine("Sayfa sonu -footer");
            Console.ReadKey();
        }
    }
}
