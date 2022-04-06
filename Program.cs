using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denyererkogren2
{
    static class helperMethod
    {
        public static string KarakterDuzelt(string str)
        {
            return str
                .Replace("ç", "c")
                .Replace("ö", "o")
                .Replace("ü", "u")
                .Replace("ğ", "g");
        }
    }
    class Urun
    {
            public int UrunId { get; set; }
            public string UrunAdi { get; set; }
            public string Acıklama { get; set; }
            public double Fiyat { get; set; }
            public bool SatıstaMi {get; set; }

 
    }
    static class Veritabani
    {
            static Urun[] urunler;

            static Veritabani()
            {
                urunler = new Urun[7];

                urunler[0] = new Urun() { UrunId = 1, UrunAdi = "Samsung S5", Acıklama = "İdare eder.", Fiyat = 10, SatıstaMi = false };
                urunler[1] = new Urun() { UrunId = 1, UrunAdi = "Samsung S6", Acıklama = "İdare eder.", Fiyat = 10, SatıstaMi = false };
                urunler[2] = new Urun() { UrunId = 1, UrunAdi = "Samsung S7", Acıklama = "İdare eder.", Fiyat = 10, SatıstaMi = false };
                urunler[3] = new Urun() { UrunId = 1, UrunAdi = "Samsung S8", Acıklama = "İdare eder.", Fiyat = 10, SatıstaMi = false };
                urunler[4] = new Urun() { UrunId = 1, UrunAdi = "Samsung S9", Acıklama = "İdare eder.", Fiyat = 10, SatıstaMi = false };
                urunler[5] = new Urun() { UrunId = 1, UrunAdi = "Samsung S10", Acıklama = "İdare eder.", Fiyat = 10, SatıstaMi = false };
                urunler[6] = new Urun() { UrunId = 1, UrunAdi = "Samsung S11", Acıklama = "İdare eder.", Fiyat = 10, SatıstaMi = false };

            }

            public static Urun[] UrunleriGetir()
            {
                return urunler;

            }


        

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Urun[] urunler = Veritabani.UrunleriGetir();
                
            foreach (var Urun in urunler)
            {
                Console.WriteLine("urun adı : {0} urun fiyatı : {1}",Urun.UrunAdi,Urun.Fiyat);
            } 


            Console.WriteLine("------------------");

            int[] sayılar = {10, 20, 30, 10, 20, 30, 10, 20, 30};
            Console.WriteLine("1. Eleman : {0}" ,sayılar[0]);
            Console.WriteLine("2. Eleman : {0}", sayılar[1]);
            Console.WriteLine("3. Eleman : {0}", sayılar[2]);


            Console.WriteLine("------------------");

            bool testResult=true;
            int not = -50;
            if (not >= 0)
            {
                testResult = true;
            }
            else if (not < 0)
            {
                testResult = false;
            }
            Console.WriteLine(testResult);

            Console.WriteLine("------------------");

            for (int i = 0; i<sayılar.Length; i++)
            {
                Console.WriteLine(sayılar[i]);
            }

            Console.WriteLine("------------------");
            int counter = 0;

            while(counter < sayılar.Length)
            {
                Console.WriteLine(sayılar[counter]);
                counter++;          
            }

            Console.WriteLine("------------------");

            foreach(int sayı in sayılar)
            {
                Console.WriteLine(sayı);
            }

            Console.WriteLine("------------------");

            string str = "ölçme ve değerlendirme";
            str = helperMethod.KarakterDuzelt(str);
            Console.WriteLine(str); ;
            
            Console.WriteLine("------------------");



            Console.Read();
        }
    }
}
