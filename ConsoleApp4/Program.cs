using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomeWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            Second1();
            Console.Clear();
            Second2();
        
        void Second1()
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
            Console.ReadLine();
        }

     
        void Second2()
        {
            double x; double y; //double result;
            Console.WriteLine("Введите координату X");
            x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату Y");
                y = Convert.ToDouble(Console.ReadLine());
            if (x > 0)
                if (y > 0) Console.WriteLine("1 четверть");
                else
                    if (y == 0) Console.WriteLine("на оси x справа");
                else
                    Console.WriteLine("4 четверть");
            else
            if (x == 0)
                if (y > 0) Console.WriteLine("на оси y сверху");
                else if (y == 0) Console.WriteLine("центр оси");
                else Console.WriteLine("га оси y снизу");
            else
                if (y > 0) Console.WriteLine("2 четверть");
                else Console.WriteLine("3 четверть");
            Console.ReadLine();
            return;
        }
    }
    }
}
