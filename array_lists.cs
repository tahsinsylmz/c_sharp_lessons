using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListOdevi1
{
    internal class Program
    {
        private static void Yazdir(ArrayList a)
        {
            foreach (var i in a)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine(" ");
        }
        private static void ortalamaDizi(ArrayList b)
        {   
            int toplam = 0;
            foreach (var i in b)
            {
                toplam += (int)i;
            }
            float ortalama = (float)toplam/(float)(b.Count);
            Console.WriteLine($", \n Liste elemanlarının ortalaması : {(float)ortalama}");
        }
        public static void Main(string[] args)
        {
            ArrayList liste1 = new ArrayList();           
            Random rnd = new Random();
            while (liste1.Count < 50)
            {
                int j = rnd.Next(1, 51);            
                liste1.Add(j);               
            }
            Console.WriteLine("\n Random 50 sayılı Liste: ");
            Yazdir(liste1);
            liste1.Insert(0, 34);
            liste1.Insert(6, 44);
            Console.WriteLine("\n Sayı atanmış Liste: ");
            Yazdir(liste1);
            liste1.Remove(liste1[8]);
            Console.WriteLine("\n 9. Eleman silinmiş Liste: ");
            Yazdir(liste1);
            int sayi;
            Console.WriteLine("\nSilmek istediğiniz sayıyı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (liste1.Contains(sayi)) {
                liste1.Remove(sayi);
                Console.WriteLine(" \n İstediğiniz sayı silinmiş Liste: ");
                Yazdir(liste1);
            }
            else {
                Console.WriteLine("\nListede Yok!");
            }
            liste1.Sort();
            liste1.Reverse();
            Console.WriteLine("\n Büyükten küçüğe sıralı Liste:\n ");
            Yazdir(liste1);
            Console.Write("\n");
            ortalamaDizi(liste1);
        }
        

       
    }
}
