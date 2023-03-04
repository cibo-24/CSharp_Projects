using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Lütfen bir geometrik şekil seçin (Daire, Üçgen, Kare, Dikdörtgen): ");
            string shape = Console.ReadLine();

            double result = 0;
            string dimension = "";

            switch (shape.ToLower())
            {
                case "daire":
                    Console.Write("Lütfen dairenin yarıçapını girin: ");
                    double radius = double.Parse(Console.ReadLine());
                    Console.Write("Hesaplanacak boyutu seçin (Çevre, Alan): ");
                    dimension = Console.ReadLine().ToLower();

                    if (dimension == "çevre")
                    {
                        result = 2 * Math.PI * radius;
                    }
                    else if (dimension == "alan")
                    {
                        result = Math.PI * Math.Pow(radius, 2);
                    }
                    break;

                case "üçgen":
                    Console.Write("Lütfen üçgenin ilk kenarını girin: ");
                    double side1 = double.Parse(Console.ReadLine());
                    Console.Write("Lütfen üçgenin ikinci kenarını girin: ");
                    double side2 = double.Parse(Console.ReadLine());
                    Console.Write("Lütfen üçgenin üçüncü kenarını girin: ");
                    double side3 = double.Parse(Console.ReadLine());
                    Console.Write("Hesaplanacak boyutu seçin (Çevre, Alan): ");
                    dimension = Console.ReadLine().ToLower();

                    double s = (side1 + side2 + side3) / 2;

                    if (dimension == "çevre")
                    {
                        Console.Write(result = side1 + side2 + side3);
                    }
                    else if (dimension == "alan")
                    {
                        Console.Write(result = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3)));
                    }
                    break;

                case "kare":
                    Console.Write("Lütfen karenin bir kenarını girin: ");
                    double side = double.Parse(Console.ReadLine());
                    Console.Write("Hesaplanacak boyutu seçin (Çevre, Alan): ");
                    dimension = Console.ReadLine().ToLower();

                    if (dimension == "çevre")
                    {
                        Console.Write(result = 4 * side);
                    }
                    else if (dimension == "alan")
                    {
                        Console.Write(result = Math.Pow(side, 2));
                    }
                    break;

                case "dikdörtgen":
                    Console.Write("Lütfen dikdörtgenin uzun kenarını girin: ");
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("Lütfen dikdörtgenin kısa kenarını girin: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Hesaplanacak boyutu seçin (Çevre, Alan): ");
                    dimension = Console.ReadLine().ToLower();

                    if (dimension == "çevre")
                    {
                        Console.Write(result = 2 * (length + width));
                    }
                    else if (dimension == "alan")
                    {
                        Console.Write(result = length * width);
                    }
                    break;

                default:
                    Console.WriteLine("Hatalı bir geometrik şekil girdiniz.");
                    break;

            }

            if (result != 0)
            {
                Console.WriteLine("{0} {1} için hesaplanan sonuç: {2}", shape, dimension, result);
            }

            Console.ReadLine();




        }
    }
}
