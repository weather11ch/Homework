using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdHomeWork

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Third3();
       
        void Third1()
        //1.	Пользователь вводит 2 числа (A и B). Возвести число A в степень B
        {
            Console.WriteLine("Введите 2 числа");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int res = 1;

            for (int i = 1; i <= b; i++)
            {
                res = res * a;
            }
                Console.WriteLine(res); Console.ReadLine();
        }
            void Third2()
            //2.	Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());
                
                for (int i = 1;i <= 1000; i++)
                {
                    if (i % a == 0) Console.WriteLine(i + " ");
                } Console.ReadLine();

             }
            void Third3()
            //3.	Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());
                int k = 0;
                for (int i = 1; i <= a*a; i++)
                {
                    if (i * i < a) k = k + 1; 
                    
                }
                Console.WriteLine("количество положительных целых чисел, квадрат которых меньше " + a + "равно" + k);
                Console.ReadLine();

            }
            void Third4()
            //4.	Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());
                int k = 0;
                
                Console.WriteLine("наибольший делитель (кроме самого A) числа " + a + "равен" + k);
                Console.ReadLine();
            }
        }
    }
}
