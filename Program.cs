using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] personelListesi = new string[5] { "mehmet gezgin", "hülya korkmaz", "meltem ay", "güneş yıldız", "sefer taş" };
            //Array.Sort(personelListesi);
            //for (int i = 0; i < personelListesi.Length; i++)
            //{
            //    Console.WriteLine("{0}", personelListesi[i]);
            //}

            //string[] günler1 = new string[7] { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
            //string[] günler2 = new string[7] { "1", "2", "3", "4", "5", "6", "7" };
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine("{0}-{1}",günler2[i],günler1[i]);
            //}

            string[] ogrenciler = new string[5] {"101","102","103","104","105" };
            int[,] notlar = new int[5, 3] { {80,90,60 },{85,75,90 },{ 60,50,70},{ 45, 60, 80 },{ 50,85,95} };
            //int j = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    double ortalama = (notlar[i, j] + notlar[i, j + 1] + notlar[i, j + 2]) / 3;
            //    Console.WriteLine("öğrenci nosu:{0} notu:{1}", ogrenciler[i], ortalama);
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    int toplam = 0;
            //    for (int j = 0; j < 3; j++)
            //    {

            //        toplam += notlar[i, j];
            //    }
            //    Console.WriteLine("öğrenci no:{0} ortalama={1}",ogrenciler[i],toplam/3);
            //}
            
            int[] çiftsayılar = new int[13];
            int sayi = 0;
            for (int i = 0; i < çiftsayılar.Length ; i++)
            {
                çiftsayılar[i] = sayi;
                Console.WriteLine("{0}", çiftsayılar[i]);
                sayi += 2;
            }


            Console.ReadKey();
        
        }
    }
}
