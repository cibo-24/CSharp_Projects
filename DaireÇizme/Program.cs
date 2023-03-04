using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaireÇizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dairenin yarıçapını girin: ");
            double yaricap = double.Parse(Console.ReadLine());

            for (int y = -(int)yaricap; y <= (int)yaricap; y++)
            {
                for (int x = -(int)yaricap; x <= (int)yaricap; x++)
                {
                    if (x * x + y * y <= yaricap * yaricap)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();


        }
    }
}
