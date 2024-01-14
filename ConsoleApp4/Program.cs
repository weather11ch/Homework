using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography;
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
            if (k == 4) { Third4(); Third4_1(); Third4_2(); }
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
            if (k == 19) { Third19(); Third19_1(); }
            if (k == 20) Third20();
            if (k == 21) Third21();
            if (k == 22) Third22();
            if (k == 23) {Third23(); Third23_1(); }
            Console.ReadLine();

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
                Console.WriteLine(res);
            }
            void Third2()
            //2.	Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());

                for (int i = a; i <= 1000; i++)
                {
                    if (i % a == 0) Console.WriteLine(i + " ");
                }

            }
            void Third3()
            //3.	Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());
                int n = 0;//кол-во
                for (int i = 0; i <= Math.Sqrt(a); i++)
                {
                    n = n + 1;
                }
                Console.WriteLine("количество положительных целых чисел, квадрат которых меньше " + a + "равно" + n);
            }
            void Third4()
            //4.	Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());
                int n = a / 2;
                int t = 0;
                while (a % n != 0) { n--; t = t + 1; }
                Console.WriteLine("наибольший делитель числа " + a + " равен " + n);
                Console.WriteLine("кол-во итераций " + t);
            }
            void Third4_1()
                //второй вариант, при четных числах оба алгоритма работают за одну итерацию, при простых числах тоже одинаково
                //а при нечетных - второй намного меньше проходов требует
            //4.	Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());
                int n = 1;
                int t = 0;
                for (int i = 2; i <= a / 2; i++)
                    if (a % i == 0)
                    {
                        n = a / i; break;
                    } else { t = t + 1; }
                
                Console.WriteLine("наибольший делитель числа " + a + " равен " + n);
                Console.WriteLine("кол-во итераций " + t);
            }
            void Third4_2()
            //третий вариант - при четных числах также
            //а при нечетных с имеющимся делителем - почти также как во втором варианте
            // при простых числах этот вариант имеет наименьшее число проходов
            //4.	Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());
                int n = 1;
                int t = 0;
                int i = 2;
                while (i <= a / i)
                {
                    i++;

                    if (a % i == 0)
                    {
                        n = a / i; break;
                    }
                    else { t = t + 1; }
                }
                Console.WriteLine("наибольший делитель числа " + a + " равен " + n);
                Console.WriteLine("кол-во итераций " + t);
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
                if (b >= a) { m = b; n = a; } else { m = a; n = b; }

                for (int i = n; i <= m; i++)
                {
                    if (i % 7 == 0) res = res + i;
                }
                Console.WriteLine("сумма всех чисел из диапазона от " + a + " до " + b + ", которые делятся без остатка на 7 равна " + res);
            }
            void Third6()
            //6.	Пользователь вводит 1 положительное число (N). Выведите N-ое число ряда фибоначчи.
            //В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1
            {
                Console.WriteLine("Введите число");
                int n = Int32.Parse(Console.ReadLine());
                int m = 1; int t = 1; int res = 1;
                for (int i = 3; i <= n; i++)
                {
                    res = m + t;
                    m = t; t = res;
                }
                Console.WriteLine(res);
            }
            void Third7()
            //7.	Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
            {
                Console.WriteLine("Введите 2 числа");
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());
                int n; int m;
                while (a != b)
                {
                    if (b >= a) { b = b - a; } else { a = a - b; }

                }

                Console.WriteLine("НОД равен " + a);
            }
            void Third8()
            //8.Пользователь вводит целое положительное число, которое является кубом целого числа N.
            //Найдите число N методом половинного деления.
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());
                int c = Math.Abs(a);
                int b = 0; int t = a / 2;
                while (Math.Abs(Math.Pow(t, 3) - a) != 0)
                {
                    if (Math.Pow(t, 3) > a) { c = t; } else { b = t; }
                    t = (c + b) / 2;
                    if (Math.Abs(c - b) <= 1) { t = 0; Console.WriteLine("Введенное целое число не является кубом целого числа"); break; }
                }
                if (t != 0) Console.WriteLine("N " + t);

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
                    a = a / 10;
                }
                Console.WriteLine(" кол-во нечетных цифр n " + n);
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
                    b = b * 10 + a % 10;
                    a = a / 10;
                }
                Console.WriteLine("b " + b);
            }
            void Third11()
            //11.Пользователь вводит целое положительное число(N).
            //Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. 
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());
                int n = 0; int m = 0; int t;
                for (int i = 2; i <= a; i++)
                {
                    //Console.WriteLine("i " + i); //Console.ReadLine();
                    t = i; m = 0; n = 0;
                    while (t % 10 != 0 || t / 10 > 0)
                    {
                        if ((t % 2) != 0) n = n + t % 10; else m = m + t % 10;
                        t = t / 10; //Console.WriteLine("n " + n + " m " + m + " t " + t); 
                        //Console.ReadLine() ;

                    }
                    if (m > n) Console.WriteLine(i);// Console.ReadLine();
                }

            }
            void Third12()
            //12.Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры.
            //Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
            {
                Console.WriteLine("Введите 2 числа");
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());
                bool res = false; int n = a; int m = a; int t = b; int l = b;

                while (m % 10 != 0 || m / 10 > 0)
                {
                    n = m % 10;
                    //Console.WriteLine("n " + n); Console.ReadLine();
                    l = b;
                    while (l % 10 != 0 || l / 10 > 0)
                    {
                        t = l % 10;
                        //Console.WriteLine("t " + t); Console.ReadLine();
                        if (t == n) { res = true; break; }
                        else l = l / 10;
                    }
                    m = m / 10; //Console.WriteLine("m " + m); Console.ReadLine();
                }
                Console.WriteLine(res);

            }
            void Third13()
            //13.Дано натуральное n. Вычислить:
            {
                Console.WriteLine("Введите число");
                int a = Int32.Parse(Console.ReadLine());
                double s = 0.00;
                for (int i = 1; i <= a; i++)
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
                double s1 = x; double s2 = 1 / x; double s3 = 1; double s4 = x;

                for (int i = 0; i <= n; i++)
                {
                    s1 = s1 * (x + i);
                    s2 = s2 + 1.0 / s1;

                }
                Console.WriteLine("Результат первого выражения " + s2);
                for (int m = 1; m <= n; m++)
                {
                    s3 = s3 * m;
                    s4 = s4 + Math.Pow(x, m) / s3;
                }
                Console.WriteLine("результат второго выражения " + s4);
            }

            void Third15()
            //15.	Дано натуральное n. Вычиcлить:
            {
                Console.WriteLine("не решено");
            }
            void Third16()
            //16.	Вычислить приближенно значение бесконечной суммы
            //(справа от каждой суммы дается ее точное значение, с которым можно сравнить полученный ответ):
            //Нужное приближение считается полученным, если вычислена сумма нескольких первых слагаемых,
            //и очередное слагаемое оказалось по модулю меньше данного положительного числа D (точность). 
            {
                Console.WriteLine("не решено");
            }

            //сумма цифр введенного числа
            int SumNumerals(int n)
            {
                int s = 0;
                while (n % 10 != 0 || n / 10 > 0)
                {
                    s = s + n % 10;
                    n = n / 10;
                }
                return s;
            }
            //
            void Third17()
            //17.	Найти все двузначные числа, сумма цифр которых не меняется при умножении числа на 2,3,4,5,6,7,8,9.
            {
                int s1; int s2; int s3;

                for (int i = 2; i <= 9; i++) // цикл для чисел от 2 до 9
                {
                    for (int j = 10; j <= 99; j++) // цикл для двузначных чисел
                    {
                        s1 = SumNumerals(j);// сумма цифр двузначного числа                        
                        s2 = i * j;// произведение двузначного числа и числа 
                        s3 = SumNumerals(s2);//сумма цифр произведения

                        if (s1 == s3) { Console.WriteLine("двузначное число " + j + " при умножении на " + i + " произв-е " + s2 + " сумма цифр " + s1); }
                    }
                }
            }
            //факториал числа
            int Factorial(int n)
            {
                int s = 1;
                for (int i = 1; i <= n; i++) { s = s * i; }
                return s;
            }
            //
            void Third18()
            //18.	Найти все трехзначные числа, представимые в виде сумм факториалов своих цифр.
            {
                int s = 0; int s1; int s2; int s3; int t;
                for (int i = 100; i <= 999; i++)
                {//Console.WriteLine("number " + i);
                    t = i; s = 0;
                    while (t % 10 != 0 || t / 10 > 0)
                    {
                        if (t % 10 != 0)
                        {
                            s = s + Factorial(t % 10); //Console.WriteLine("цифра " + t%10 + " факториал " + Factorial(t % 10) + " сумма факториалов " + s);
                        }
                        t = t / 10;

                    }
                    if (s == i) { Console.WriteLine("число " + i + " представимо в виде суммы факториалов своих цифр"); }
                }

            }
            void Third19()
            //19.	Можно ли заданное натуральное число М представить в виде суммы квадратов двух натуральных чисел?
            //Написать программу решения этой задачи.
            {
                Console.WriteLine("Введите натуральное число");
                int n = Int32.Parse(Console.ReadLine()); 
                bool l = false;
                int t = 0;
                for (int i = 1; i <= Math.Sqrt(n)+1; i++)
                {
                    for (int j = i + 1; j <= Math.Sqrt(n); j++)
                    {
                        if (n == (j * j + i * i)) { l = true; Console.WriteLine("можно представить в виде суммы квадратов  чисел i " + i + " и j " + j); }
                        t = t + 1;
                    }
                }
                if (l == false) { Console.WriteLine("Введенное число нельзя представить в виде суммы квадратов двух натуральных чисел"); }
                Console.WriteLine("кол-во итераций " + t);
            }
            void Third19_1()
            //19.	Можно ли заданное натуральное число М представить в виде суммы квадратов двух натуральных чисел?
            //Написать программу решения этой задачи.
            {
                Console.WriteLine("Введите натуральное число");
                int n = Int32.Parse(Console.ReadLine()); 
                int l = 0;
                int t = 0;
                for (int i = 1; i <= Math.Sqrt(n-1); i++)
                {
                    for (int j = i + 1; j <= Math.Sqrt(n-(i*i)) ; j++)
                    {
                        if (n == (j * j + i * i)) { l = l + 1; Console.WriteLine("можно представить в виде суммы квадратов  чисел i " + i + " и j " + j); }
                        t = t + 1;
                    }
                }
                if (l == 0) { Console.WriteLine("Введенное число нельзя представить в виде суммы квадратов двух натуральных чисел"); }
                Console.WriteLine("кол-во итераций " + t);
            }
            void Third20()
            //20.	Определить, является ли заданное число совершенным , т.е. равным сумме всех своих (положительных) делителей,
            //кроме самого этого числа (например, число 6 совершенно: 6=1+2+3).
            {
                Console.WriteLine("Введите натуральное число");
                int a = Int32.Parse(Console.ReadLine()); int s = 0;
                for (int i = 1; i < a; i++)
                {
                    if (a % i == 0) { s = s + i; Console.WriteLine("делитель " + i); }
                }
                if (s == a) { Console.WriteLine("число совершенное, равно сумме всех своих положительных делителей"); }
                else { Console.WriteLine("число не равно сумме всех своих положительных делителей"); }
            }

            int countNumerals(int n)
            {
                int result = 0;
                while (n > 0)
                {
                    result++;
                    n = n / 10;
                }
                return result;
            }

            void Third21()
            //21.	Дано натуральное k. Напечатать k-ю цифру последовательности 1234567891011121314...,
            //в которой выписаны подряд все натуральные числа.
            {
                Console.WriteLine("Введите натуральное число");
                int a = Int32.Parse(Console.ReadLine()); int length = 0; int t = 1; int j;
                while (length < a)
                {
                    Console.Write(t);
                    length = length + countNumerals(t);
                    t++;
                }
                t--;
                int number = t / Convert.ToInt32(Math.Pow(10, length - a));
                Console.WriteLine("\n" + t);
                Console.WriteLine(a + "-ая цифра в ряду равна " + number % 10);

            }
            void Third22()
            //22.	Дано натуральное k.
            //Напечатать k-ю цифру последовательности 149162536..., в которой выписаны подряд квадраты всех натуральных чисел.
            {
                Console.WriteLine("Введите натуральное число");
                int a = Int32.Parse(Console.ReadLine()); int length = 0; int t = 1; int j;
                while (length < a)
                {
                    Console.Write(t * t);
                    length = length + countNumerals(t * t);
                    t++;
                }
                t--;
                int number = t * t / Convert.ToInt32(Math.Pow(10, length - a));
                //Console.WriteLine("\n" + t * t);
                Console.WriteLine(a + "-ая цифра в ряду равна " + number % 10);
            }

            void Third23()
            //23.	Дано натуральное k.
            //Напечатать k-ю цифру последовательности 1123581321..., в которой выписаны подряд все числа Фибоначчи.
            {
                Console.WriteLine("Введите натуральное число");
                int a = Int32.Parse(Console.ReadLine()); int length = 0; int t = 1; int j;
                while (length < a)
                {
                    Console.Write(numFib(t));
                    length = length + countNumerals(numFib(t));
                    t++;
                }
                t--;
                int number = numFib(t) / Convert.ToInt32(Math.Pow(10, length - a));
                Console.WriteLine("\n" + numFib(t));
                Console.WriteLine(a + "-ая цифра в ряду равна " + number % 10);
            }
            int numFib(int n)
            {
                int m = 1; int t = 1; int res = 1;
                for (int i = 3; i <= n; i++)
                {
                    res = m + t;
                    m = t; t = res;
                }
                return res;
            }
            void Third23_1()
            //23.	Дано натуральное k.
            //Напечатать k-ю цифру последовательности 1123581321..., в которой выписаны подряд все числа Фибоначчи.
            {
                Console.WriteLine("Введите натуральное число");
                int a = Int32.Parse(Console.ReadLine());
                int length = 1; 
                int t = 1; 
                int i  = 0; int m = 0; int res = 1;
                Console.Write(res);
                while (length < a)
                {
                     res = m + t;
                    m = t; t = res;
                    Console.Write(res);
                    length = length + countNumerals(res);
                   
                    res++;
                }
                res--;
                int number = res / Convert.ToInt32(Math.Pow(10, length - a));
                Console.WriteLine("\n" + res);
                Console.WriteLine(a + "-ая цифра в ряду равна " + number % 10);
            }
        }
    }
}
