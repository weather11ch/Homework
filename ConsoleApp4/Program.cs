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
            int k;
            Console.WriteLine("Введите номер задачи (от 1 до 5)");
            k = Int32.Parse(Console.ReadLine());
            if (k == 1) Third1();
            if (k == 2) Third2();
            if (k == 3) Third3();
            if (k == 4) Third4();
            if (k == 5) Third5();
            if (k == 6) Third6();
            if (k == 7) Third7();
            Third5();
       
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
                int k = a -1;
                while(a%k !=0) { k--; }
                Console.WriteLine("наибольший делитель числа " + a + " равен " + k);
                Console.ReadLine();
            }
            void Third5()
            //5.	Пользователь вводит 2 числа (A и B).
            //Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7.
            //(Учтите, что при вводе B может оказаться меньше A).
            {
                Console.WriteLine("Введите 2 числа");
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());
                int res = 0; int n; int m;
                if (b >=a) { m= b; n = a; } else { m= a; n = b;}
                
                    for (int i = n;i <= m; i++)
                    {
                        if (i%7 == 0) res = res + i;
                    }
                 
                Console.WriteLine("сумма всех чисел из диапазона от " + a + " до " + b + ", которые делятся без остатка на 7 равна " + res);
                Console.ReadLine();
            }
            void Third6()
            //6.	Пользователь вводит 1 положительное число (N). Выведите N-ое число ряда фибоначчи.
            //В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1
            {

            }
            void Third7()
            //7.	Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
            {

            }
        }
    }
}
