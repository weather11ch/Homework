using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomeWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            double k; 
            Console.WriteLine("Введите номер задачи (от 1 до 6)");
            k = Convert.ToDouble(Console.ReadLine());
            if (k==1) Second1();
            if (k==2) Second2();
            if (k==3) Second3();
            if (k==4) Second4();
            //Console.Clear();
            

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
            void Second3()
            {
                double a; double b; double c; double result;
                Console.WriteLine("Введите три числа");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                if (a < b)
                    if (b < c) Console.WriteLine(a + ", " + b + ", " + c);
                    else if (a < c) Console.WriteLine(a + ", " + c + ", " + b);
                         else Console.WriteLine(c + ", " + a + ", " + b);
                else
                    if (b > c) Console.WriteLine(c + ", " + b + ", " + a);
                else
                    if (c > a) Console.WriteLine(b + ", " + a + ", " + c);
                else Console.WriteLine(b + ", " + c + ", " + a);


                Console.ReadLine();
            }

            void Second4()
            {
                double a; double b; double c; double d; double x1; double x2;
                Console.WriteLine("Введите три числа для решения квадратного уравнения");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                d = b * b - 4 * a * c; Console.WriteLine("D = " + d);
                    if (d > 0) { x1 = (-b + Math.Sqrt(d))/(2*a); x2 = (-b - Math.Sqrt(d))/(2*a);
                    Console.WriteLine("x1 = " + x1 + "; x2 = " + x2); }
                else
                    if (d == 0) {x1 = -b / (2 * a);  Console.WriteLine("x = " + x1); }
                else Console.WriteLine("решения нет");
                
                Console.ReadLine();
            }
            void Second5()
            {
                double a; double b; double c; double d; double x1; double x2;
                Console.WriteLine("Введите три числа для решения квадратного уравнения");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                d = b * b - 4 * a * c; Console.WriteLine("D = " + d);
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a); x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("x1 = " + x1 + "; x2 = " + x2);
                }
                else
                if (d == 0) { x1 = -b / (2 * a); Console.WriteLine("x = " + x1); }
                else Console.WriteLine("решения нет");

                Console.ReadLine();
            }
        }
    }
}
