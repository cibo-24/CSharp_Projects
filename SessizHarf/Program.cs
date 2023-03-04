using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessizHarf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir metin girin: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            string consonants = "bcdfghjklmnpqrstvwxyz";

            foreach (string word in words)
            {
                bool hasConsecutiveConsonants = false;

                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (consonants.Contains(word[i]) && consonants.Contains(word[i + 1]))
                    {
                        hasConsecutiveConsonants = true;
                        break;
                    }
                }

                Console.Write(hasConsecutiveConsonants + " ");
            }

            Console.WriteLine();



        }
    }
}
