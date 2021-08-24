using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 84;

            //Uzun Uzun her kurs için yazmak yerine..
            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " " + kurs1.IzlenmeOrani);
            //Console.WriteLine(kurs2.KursAdi + " " + kurs2.Egitmen + " " + kurs2.IzlenmeOrani);
            //Console.WriteLine(kurs3.KursAdi + " " + kurs3.Egitmen + " " + kurs3.IzlenmeOrani);

            //Dizi oluşturarak daha kolay ve daha az kodla erişmek.
            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };
            //Döngü ile çekiyoruz ekran çıktısına
            foreach (var abc in kurslar)
            {
                Console.WriteLine(abc.KursAdi + " " + abc.Egitmen + " " + abc.IzlenmeOrani);
            }
            Console.ReadKey();
        }
    }

    //Kendi veri tipini oluşturma
    //prop+TabTab Property=Özellik demek 
    class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
