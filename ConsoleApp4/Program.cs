using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            Square f1 = new Square(5, "зеленый");
            Square f2 = new Square(2, "синий");
            Square f3 = new Square(15, "голубой");

            List<Square> sqs = new List<Square>()
            {
                f1, f2, f3
            };

            foreach (var squares in sqs)
            {
                squares.AboutSqaure();
            }
            Square f4 = new Square(6, "зеленый");
            sqs.Add(f4);
            f1.a = 6;
            foreach (var squares in sqs)
            {
                squares.AboutSqaure();
            }

            Console.ReadLine();
        }
    }
}
