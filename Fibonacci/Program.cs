using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int depth;

            Console.Write("Fibonacci serisi derinliği: ");
            depth = Convert.ToInt32(Console.ReadLine());

            int[] fib = new int[depth];
            fib[0] = 0;
            if (depth > 1)
            {
                fib[1] = 1;
            }

            for (int i = 2; i < depth; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            double sum = 0;
            for (int i = 0; i < depth; i++)
            {
                sum += fib[i];
            }

            double average = sum / depth;
            Console.WriteLine("Fibonacci serisi ortalaması: " + average);


        }
    }
}
