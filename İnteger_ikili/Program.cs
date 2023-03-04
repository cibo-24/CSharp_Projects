using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnteger_ikili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayı girilecek (Çift olmalıdır)?");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int[] sayıListesi = new int[sayı];

            if (sayı % 2 == 0)
            {
                for (int i = 0; i < sayı; i++)
                {
                    Console.WriteLine("{0}. sayınız: ", i + 1);
                    sayıListesi[i] = Convert.ToInt32(Console.ReadLine());
                }


                for (int i = 0; i < sayıListesi.Length; i += 2)
                {
                    if (sayıListesi[i] == sayıListesi[i + 1])
                    {
                        int toplam = sayıListesi[i] + sayıListesi[i + 1];
                        Console.Write(" " + toplam * toplam + " ");
                    }
                    else
                    {
                        int toplam = sayıListesi[i] + sayıListesi[i + 1];
                        Console.Write(" " + toplam + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("\aÇift sayı giriniz.");
            }



        }
    }
}
