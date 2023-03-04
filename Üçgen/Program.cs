using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Üçgen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Üçgenin kenar uzunluğunu girin: ");
            int kenarUzunlugu = int.Parse(Console.ReadLine());

            for (int i = 1; i <= kenarUzunlugu; i++)
            {
                for (int j = 1; j <= kenarUzunlugu - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();


        }
    }
}
