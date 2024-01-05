using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ThirdHomeWork

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k;
            Console.WriteLine("Введите номер задачи (от 1 до 23)");
            k = Int32.Parse(Console.ReadLine());
            if (k == 1) Third1();
            if (k == 2) Third2();
            if (k == 3) Third3();
            if (k == 4) Third4();
            if (k == 5) Third5();
            if (k == 6) Third6();
            if (k == 7) Third7();
            if (k == 8) Third8();
            if (k == 9) Third9();
            if (k == 10) Third10();
            if (k == 11) Third11();
            if (k == 12) Third12();
            if (k == 13) Third13();
            if (k == 14) Third14();
            if (k == 15) Third15();
            if (k == 16) Third16();
            if (k == 17) Third17();
            if (k == 18) Third18();
            if (k == 19) Third19();
            if (k == 20) Third20();
            if (k == 21) Third21();
            if (k == 22) Third22();
            if (k == 23) Third23();


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
                int n = 0;//кол-во
                for (int i = 0; i <= Math.Sqrt(a); i++)
                {
                    if (i * i < a) n = n + 1; 
                    
                }
                Console.WriteLine("количество положительных целых чисел, квадрат которых меньше " + a + "равно" + n);
                Console.ReadLine();

            }
            void Third4()
            //4.	Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());
                int n = a -1;
                while(a%n !=0) { n--; }
                Console.WriteLine("наибольший делитель числа " + a + " равен " + n);
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
                Console.WriteLine("Введите число");
                int n = Int32.Parse(Console.ReadLine());
                int m = 1; int t = 1 ; int res = 1;
                for (int i= 3; i <= n; i++)
                {
                    res = m + t;
                    m = t; t = res;
                }
                Console.WriteLine(res);
                Console.ReadLine();
            }
            void Third7()
            //7.	Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
            {
                Console.WriteLine("Введите 2 числа");
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());
                int res = 0; int n; int m;
                while (a!=b) 
                { 
                if (b >= a) {b=b- a; } else {a = a-b; }

                }

                Console.WriteLine("НОД равен " + a);
                Console.ReadLine();
            }
            void Third8()
            //8.Пользователь вводит целое положительное число, которое является кубом целого числа N.
            //Найдите число N методом половинного деления.
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());
                int c = Math.Abs(a);
                int b = 0; int t = a/2;
                while ( Math.Abs(Math.Pow(t, 3) - a) != 0)
                {
                    if (Math.Pow(t, 3) > a) { c = t; } else {  b = t; }
                    t = (c + b) / 2; 
                    if (Math.Abs(c - b) <= 1) { t = 0; Console.WriteLine("Введенное целое число не является кубом целого числа"); break; } 
                    
                }
                if (t != 0) Console.WriteLine("N " + t);
               
                Console.ReadLine();
            }
            void Third9()
            //9.	Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
            
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());
                int n = 0; int b = a;
                while (a % 10 != 0)
                {
                    if ((a % 2) != 0) n = n + 1;
                    a = a/ 10;                                       
                }
                Console.WriteLine(" кол-во нечетных цифр n " + n);
                Console.ReadLine();
            }
            void Third10()
            //10.Пользователь вводит 1 число.Найти число, которое является зеркальным отображением последовательности цифр заданного числа,
            //например, задано число 123, вывести 321.
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());
                int b = 0;
                while (a % 10 != 0)
                {
                    b = b *10 + a % 10;
                    a = a / 10;
                }
                Console.WriteLine("b " + b);
                Console.ReadLine();
            }
            void Third11()
            //11.Пользователь вводит целое положительное число(N).
            //Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. 
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());
                int n = 0; int m = 0; int t;
                for (int i = 2; i <= a; i++) {
                    //Console.WriteLine("i " + i); //Console.ReadLine();
                    t = i; m = 0; n = 0;
                    while (t % 10 != 0 || t / 10 > 0)
                    {
                        if ((t % 2) != 0) n = n + t%10; else m= m + t%10;
                        t = t / 10; //Console.WriteLine("n " + n + " m " + m + " t " + t); 
                        //Console.ReadLine() ;

                    }
                    if (m > n) Console.WriteLine(i);// Console.ReadLine();
                }
                
                //20
                Console.ReadLine();
            }
            void Third12()
            //12.Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры.
            //Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
            {
                Console.WriteLine("Введите 2 числа");
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());
                bool res = false; int n = a; int m = a; int t = b; int l = b;
                
                while (m%10 != 0)
                {
                    n = m % 10;
                    //Console.WriteLine("n " + n); Console.ReadLine();
                    l = b;
                    while (l % 10 != 0)
                    {
                        t = l % 10;
                        //Console.WriteLine("t " + t); Console.ReadLine();
                        if (t == n) { res = true; break; }
                        else l = l/10;
                    } 
                    m = m / 10; //Console.WriteLine("m " + m); Console.ReadLine();
                }
                Console.WriteLine(res);
                Console.ReadLine() ;

            }
            void Third13()
            //13.Дано натуральное n. Вычислить:
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());
                double s = 0.00; 
                for (int i = 1; i <=a; i++)
                {
                    s = s + (1.0 + 1.0 / (i * i)); Console.WriteLine("s " + s);                    
                }
                Console.WriteLine(s);
                
            }
            void Third14()
            //14.	Дано действительное число х, натуральное число n. Вычислить:
            {
                Console.WriteLine("Введите натуральное число");
                int n = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите вещественное число");
                double x = Double.Parse(Console.ReadLine());
                double s1 =  x; double s2 = 1/x;

                for (int i = 0; i <= n; i++)
                {
                    s1 = s1* (x + i); 
                    s2 = s2 + 1.0/s1;
                }
                
                Console.WriteLine(s2);
             }

            void Third15()
            //13.Дано натуральное n. Вычислить:
            {

            }
            void Third16()
            //13.Дано натуральное n. Вычислить:
            {

            }
            void Third17()
            //13.Дано натуральное n. Вычислить:
            {

            }
            void Third18()
            //13.Дано натуральное n. Вычислить:
            {

            }
            void Third19()
            //13.Дано натуральное n. Вычислить:
            {

            }
            void Third20()
            //13.Дано натуральное n. Вычислить:
            {

            }
            void Third21()
            //13.Дано натуральное n. Вычислить:
            {

            }
            void Third22()
            //13.Дано натуральное n. Вычислить:
            {

            }
            void Third23()
            //13.Дано натуральное n. Вычислить:
            {

            }
            
        }
    }
}
