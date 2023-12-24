using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a; double b; double result;
            Console.WriteLine("Введите два числа");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if (a > b) result = a + b;
            else
                if (a == b) result = a * b;
            else
                result = a - b;
            Console.WriteLine(result);
        }
    }
}
