using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Square 2. Diamond 3. Rectangle  4. Round 5. Triangle");
            Console.Write("Choose One:");
            int choose = Convert.ToInt16(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Input side:");
                    int s = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Area: " + (s * s));
                    Console.WriteLine("around: " + (4 * s));
                    break;
                case 2:
                    Console.WriteLine("Input side a:");
                    Console.WriteLine("Input side b:");
                    Console.WriteLine("Input Height: ");
                    int height = Convert.ToInt16(Console.ReadLine());
                    int a = Convert.ToInt16(Console.ReadLine());
                    int b = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Area: " + (a * height));
                    Console.WriteLine("around: " + (2 * (a + b)));
                    break;
                case 3:
                    Console.WriteLine("Input Base: ");
                    Console.WriteLine("Input Height: ");
                    int x = Convert.ToInt16(Console.ReadLine());
                    int y = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Area: " + (x * y));
                    Console.WriteLine("around: " + (2 * (x * y)));
                    break;
                case 4:
                    Console.WriteLine("Input Radius");
                    int r = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Area: " + (3.14 * r * r));
                    Console.WriteLine("around: " + (3.14 * 2 * r));
                    break;
                case 5:
                    Console.WriteLine("Input side");
                    Console.WriteLine("Input height");
                    int side = Convert.ToInt16(Console.ReadLine());
                    int h = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Area: " + (0.5 * side * h));
                    Console.WriteLine("around: " + (side + side + side));
                    break;
                default:
                    Console.WriteLine("Pilihan anda tidak tersedia!");
                    break;
            }
        }

    }
}