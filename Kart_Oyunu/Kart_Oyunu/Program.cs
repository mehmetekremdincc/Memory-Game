using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kart_Oyunu
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bas:
            Console.WriteLine("***Hafıza Kart Oyunumuza Hoşgeldiniz***");
            List<string> sayılar = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"};
            List<string> sayilar2 = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" };
            int sayaç2 = 0;
            foreach (string Sayılar in sayılar)
            {
                Console.Write("|" + Sayılar + "|");
                sayaç2++;
                if (sayaç2 == 4)
                {
                    sayaç2 = 0;
                    Console.WriteLine();
                }
            }
            DateTime baslangıc = DateTime.Now;
            char[] harfler = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            Random rnd = new Random();
            int değer1 = 0;
            int değer2 = 0;
            char değer;
            for (int i = 0; i < 17; i++)
            {
                değer1 = rnd.Next(0, harfler.Length - 1);
                değer = harfler[değer1];
                değer2 = rnd.Next(0, harfler.Length - 1);
                harfler[değer1] = harfler[değer2];
                harfler[değer2] = değer;
            }
            int hamle = 0;
            int KartSayac = 0;
            int sonuç = 0;
        kartlar:
            int kart1 = 0;
            try
            {
                Console.Write("Lüfen 1. kartı seçiniz:");
                kart1 = Convert.ToInt32(Console.ReadLine());
                hamle++;
            }
            catch (Exception)
            {
                Console.WriteLine("Geçersiz değer girdiniz");
                goto kartlar;
            }
            if (kart1 > 16 || kart1 < 0)
            {
                Console.WriteLine("Hatalı değer girdiniz.Lütfen tekrar deneyiniz.");
                goto kartlar;
            }
            if (sayılar[kart1 - 1] != sayilar2[kart1 - 1])
            {
                Console.WriteLine("Bu kart zaten açık.");
                goto kartlar;
            }
            int kart2 = 0;
            try
            {
                Console.Write("Lüfen 2. kartı seçiniz:");
                kart2 = Convert.ToInt32(Console.ReadLine());
                hamle++;
            }
            catch (Exception)
            {
                Console.WriteLine("Geçersiz değer girdiniz.");
                goto kartlar;
            }
            if (kart2 > 16 || kart1 < 0)
            {
                Console.WriteLine("Hatalı değer girdiniz.Lütfen tekrar deneyiniz.");
                goto kartlar;
            }
            if (sayılar[kart2 - 1] != sayilar2[kart2 - 1])
            {
                Console.WriteLine("Bu kart zaten açık.");
                goto kartlar;
            }
            Console.WriteLine();
            char harf1 = harfler[kart1 - 1];
            char harf2 = harfler[kart2 - 1];
            sayılar[kart1 - 1] = harf1.ToString();
            sayılar[kart2 - 1] = harf2.ToString();
            SayılarıEkranaGöster(sayılar);
            if (harf1 == harf2)
            {
                Console.WriteLine("Eşleşme başarılı");
                sonuç++;
                if (sonuç == 8)
                {
                    TimeSpan bıtıs = DateTime.Now - baslangıc;
                    Console.WriteLine("***Tebrikler Oyunu Kazandınız***");
                    Console.Write("Hamle sayınız:" + hamle);
                    KartSayac = hamle / 2;
                    Console.WriteLine();
                    Console.Write("Tur sayınız:" + KartSayac);
                    Console.WriteLine();
                    Console.Write("Geçen zaman:" + bıtıs);
                    Console.WriteLine();
                    goto bas;
                }
                goto kartlar;
            }
            else
            {
                Console.WriteLine("Tekrar deneyiniz");
                sayılar[kart1 - 1] = kart1.ToString();
                sayılar[kart2 - 1] = kart2.ToString();
                goto kartlar;
            }
        }
        static void SayılarıEkranaGöster(List<string> sayılar)
        {
            int sayaç = 0;
            foreach (string Sonuçlar in sayılar)
            {
                Console.Write("|" + Sonuçlar + "|");
                sayaç++;
                if (sayaç == 4)
                {
                    sayaç = 0;
                    Console.WriteLine();
                }
            }
        }
    } 
}