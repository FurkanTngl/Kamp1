using System;

namespace OdevClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRENDYOL SEPETİM..");
            //Kadınlar için
            KadınGiyim Urun1 = new KadınGiyim();
            Urun1.UrunAdi = "Happiness İst. Kadın Beyaz Oversize Uzun Basic Gömlek";
            Urun1.UrunFiyati = 52.47;

            KadınGiyim urun2 = new KadınGiyim();
            urun2.UrunAdi = "TRENDYOLMİLLA Ekru Toile De Jouy Gömlekli Alt - Üst Takım";
            urun2.UrunFiyati = 95.99;

            KadınGiyim urun3 = new KadınGiyim();
            urun3.UrunAdi = "armonika Kadın Siyah Bahçivan Tulum";
            urun3.UrunFiyati = 37.07;

            //ASIL MESELE BURASI!
            KadınGiyim[] UrunlerK = new KadınGiyim[] { Urun1, urun2, urun3 };
            foreach (var xyz in UrunlerK)
            {
                Console.WriteLine(xyz.UrunAdi + " Ürün Fiyatı: " + xyz.UrunFiyati);
                Console.WriteLine();
            }

            //Erkekler İçin
            ErkekGiyim Urun4 = new ErkekGiyim();
            Urun4.UrunAdi = "MOSST Gömlek Şort Takım";
            Urun4.UrunFiyati = 169.99;

            ErkekGiyim Urun5 = new ErkekGiyim();
            Urun5.UrunAdi = "JACKS MAN Beyaz Oversize T - shirt";
            Urun5.UrunFiyati = 49.99;

            ErkekGiyim Urun6 = new ErkekGiyim();
            Urun6.UrunAdi = "TRENDYOL MAN Lacivert Şerit Detaylı Baskılı Örme Pijama Takımı";
            Urun6.UrunFiyati = 40;

            //ASIL MESELE BURASI!
            ErkekGiyim[] UrunlerE = new ErkekGiyim[] { Urun4, Urun5, Urun6 };      
            foreach (var abc in UrunlerE)
            {
                Console.WriteLine(abc.UrunAdi + " Ürün Fiyatı: " + abc.UrunFiyati);
                Console.WriteLine();
            }
            Console.ReadKey();  
        }
    }

    class KadınGiyim
    {
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }
    }
    class ErkekGiyim
    {
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }
    }

}
