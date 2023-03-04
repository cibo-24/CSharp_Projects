using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutlak_Kare_Alma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Kaç tane sayı gireceksiniz? ");
            int n = int.Parse(Console.ReadLine());

            int sumOfDifferences = 0;
            int sumOfSquares = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}. sayı: ");
                int num = int.Parse(Console.ReadLine());

                if (num < 67)
                {
                    sumOfDifferences += 67 - num;
                }
                else
                {
                    int diff = num - 67;
                    sumOfSquares += diff * diff;
                }
            }

            Console.WriteLine($"Küçük olanların farklarının toplamı: {sumOfDifferences}");
            Console.WriteLine($"Büyük olanların farklarının mutlak kareleri toplamı: {sumOfSquares}");

        }
    }
}
