using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Lütfen Sayi Giriniz(1-9999)");
                int sayi = Convert.ToInt32(Console.ReadLine());
                //sifir geldiginde hata alınmamısı icin index 1 artırıldı
                string[] birlerbas = new string[] { "", "BİR", "İKİ", "ÜÇ", "DÖRT", "BEŞ", "ALTI", "YEDİ", "SEKİZ", "DOKUZ" };
                string[] onlarbas = new string[] { "", "ON", "YİRMİ", "OTUZ", "KIRK", "ELLİ", "ALTMIŞ", "YETMİŞ", "SEKSEN", "DOKSAN" };
                string[] yuzlerbas = new string[] { "", "YÜZ", "İKİYUZ", "ÜÇYÜZ", "DÖRTYÜZ", "BEŞYÜZ", "ALTIYÜZ", "YEDİYÜZ", "SEKİZYÜZ", "DOKUZYÜZ" };
                string[] binbas = new string[] { "", "BİN", "İKİBİN", "ÜÇBİN", "DÖRTBİN", "BEŞBİN", "ALTIBİN", "YEDİBİN", "SEKİZBİN", "DOKUZBİN" };

                if (sayi <= 0 || sayi > 10000)
                {
                    Console.WriteLine("Sayı aralık dışında");

                }
                else
                {
                    int obb = sayi / 1000;
                    int yb = (sayi / 100) % 10;
                    int ob = (sayi / 10) % 10;
                    int bb = (sayi) % 10;
                    try
                    {
                        Console.WriteLine((binbas[obb] + yuzlerbas[yb] + onlarbas[ob] + birlerbas[bb]));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Sayı dönüştürelemedi");
                    }
                }
            }


        }
    }
}
