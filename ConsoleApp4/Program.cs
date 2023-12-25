using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomeWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            int k; 
            Console.WriteLine("Введите номер задачи (от 1 до 7)");
            k = Int32.Parse(Console.ReadLine());
            if (k==1) Second1();
            if (k==2) Second2();
            if (k==3) Second3();
            if (k==4) Second4();
            if (k==5) Second5();
            if (k==6) Second6();
            if (k == 7) Second7();
            //Console.Clear();
            

            void Second1()
            //1.	Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
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
            //2.	Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).
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
            //3.	Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.
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
            //4.	Пользователь вводит 3 числа (A, B и С).
            //Выведите в консоль решение(значения X) квадратного уравнения стандартного вида

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
            //5.	Пользователь вводит двузначное число.
            //Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
            {
                Console.WriteLine("Введите двузначное число");

                int number = Convert.ToInt32(Console.ReadLine());
                int numDes = number / 10;
                int numEd = number % 10;
                Console.WriteLine("des " + numDes + " Ed " + numEd);

                if (numDes >= 2)
                {
                    string numberTextEd = "";

                    switch (numEd)
                    {
                        case 1:
                            numberTextEd = "один";
                            break;
                        case 2:
                            numberTextEd = "два";
                            break;
                        case 3:
                            numberTextEd = "три";
                            break;
                        case 4:
                            numberTextEd = "четыре";
                            break;
                        case 5:
                            numberTextEd = "пять";
                            break;
                        case 6:
                            numberTextEd = "шесть";
                            break;
                        case 7:
                            numberTextEd = "семь";
                            break;
                        case 8:
                            numberTextEd = "восемь";
                            break;
                        case 9:
                            numberTextEd = "девять";
                            break;
                    }

                    string numberTextDes = "";
                    switch (numDes)
                    {
                        case 2:
                            numberTextDes = "двадцать";
                            break;
                        case 3:
                            numberTextDes = "тридцать";
                            break;
                        case 4:
                            numberTextDes = "сорок";
                            break;
                        case 5:
                            numberTextDes = "пятьдесят";
                            break;
                        case 6:
                            numberTextDes = "шестьдесят";
                            break;
                        case 7:
                            numberTextDes = "семьдесят";
                            break;
                        case 8:
                            numberTextDes = "восемьдесят";
                            break;
                        case 9:
                            numberTextDes = "девяносто";
                            break;

                    }

                    Console.WriteLine(number + " - " + numberTextDes + " " + numberTextEd);

                }
                else if (numDes == 1)
                {
                    string numberTextFirstDes = "";
                    switch (number)
                    {
                        case 10:
                            numberTextFirstDes = "десять";
                            break;
                        case 11:
                            numberTextFirstDes = "одиннадцать";
                            break;
                        case 12:
                            numberTextFirstDes = "двенадцать";
                            break;
                        case 13:
                            numberTextFirstDes = "тринадцать";
                            break;
                        case 14:
                            numberTextFirstDes = "четырнадцать";
                            break;
                        case 15:
                            numberTextFirstDes = "пятнадцать";
                            break;
                        case 16:
                            numberTextFirstDes = "шестнадцать";
                            break;
                        case 17:
                            numberTextFirstDes = "семнадцать";
                            break;
                        case 18:
                            numberTextFirstDes = "восемнадцать";
                            break;
                        case 19:
                            numberTextFirstDes = "девятнадцать";
                            break;

                    }
                    Console.WriteLine(number + " - " + numberTextFirstDes);

                }
                else Console.WriteLine("Вы ввели не двузачное число");
                Console.ReadLine();

            }
            void Second6()
            //6.	Определить, попадает ли точка M(x,y) в круг радиусом r с центром в точке (x0,y0)
            {
               double x; double y; 
               double x1; double y1; double z; double r; 
                Console.WriteLine("Введите координаты точки");
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координаты центра окружности");
                x1 = Convert.ToDouble(Console.ReadLine());
                y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите радиус");
                r = Convert.ToDouble(Console.ReadLine());
                z = Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1));
                if (z > r ) { Console.WriteLine("точка M не попадает в круг заданного радиуса"); }
                else if (z == r) { Console.WriteLine("точка М лежит на окружности круга"); }
                else { Console.WriteLine("точка М расположена внутри круга"); }
                
                Console.ReadLine();
            }
            void Second7()
                /*7.	Написать программу, которая печатает True или False в зависимости от того, выполняются или нет заданные условия:
            a.квадрат заданного трехзначного числа равен кубу суммы цифр этого числа;
            b.сумма двух первых цифр заданного четырехзначного числа равна сумме двух его последних цифр;
            c.среди цифр заданного трехзначного числа есть одинаковые;
            d.среди первых трех цифр из дробной части заданного положительного вещественного числа есть цифра 0. */

            {
                int number;
                int numTys; int numSot; int numDes; int numEd; int result;
                bool a; bool b; bool c; bool d;
                //a
                Console.WriteLine("Введите трехзначное число");
                number = Int32.Parse(Console.ReadLine());
                numSot = number / 100;
                if (numSot > 0)
                {
                    numEd = number % 100;
                    numDes = (number - (100 * numSot)) / 10; result = numSot + numDes + numEd;
                    if (number * number == Math.Pow(result, 3)) a = true; else a = false;
                    Console.WriteLine("a " + a);
                } else Console.WriteLine("Введено не трехзначное число");
                //b
                Console.WriteLine("Введите чеырехзначное число");
                number = Int32.Parse(Console.ReadLine());
                numTys = number / 1000;
                if (numTys > 0) //4-х значное число
                {
                     numSot = (number - (1000*numTys))/ 100;
                     numEd = number % 1000;
                    if (numSot >= 0)
                    {
                         numDes = (number - (1000 * numTys) - (100*numSot)) / 10;
                        if ((numTys + numSot) == (numDes + numEd)) b = true; else b = false; //b
                        Console.WriteLine("b " + b);
                    }
                }
                else Console.WriteLine("Введено не четырехзначное число");
                //c
                Console.WriteLine("Введите трехзначное число");
                number = Int32.Parse(Console.ReadLine());
                numSot = number / 100;
                if (numSot > 0)
                {
                    numEd = number % 100;
                    numDes = (number - (100 * numSot)) / 10;
                    if (numSot == numDes | numDes == numEd | numSot == numDes) c = true; else c = false;
                    Console.WriteLine("c " + c);
                }
                else Console.WriteLine("Введено не трехзначное число");
                
                //d
                Console.WriteLine("Введите положительное вещественное  число");
                decimal num4 =decimal.Parse(Console.ReadLine());
                decimal num4Dec1 = num4 - Math.Round(num4); Console.WriteLine("num4Dec1 " + num4Dec1);//выделение дробной части
                decimal num4Round1 = Math.Round(num4Dec1*10); Console.WriteLine("num4Round1 " + num4Round1);//1 цифра
                decimal num4Dec2 = num4Dec1 * 10 - num4Round1;
                decimal num4Round2 = Math.Round(num4Dec2 * 10); Console.WriteLine("num4Round2 " + num4Round2);// 2 цифра
                decimal num4Dec3 = num4Dec2 * 10 - num4Round2;
                decimal num4Round3 = Math.Round(num4Dec3 * 10); Console.WriteLine("num4Round3 " + num4Round3);// 2 цифра
                if (num4Round1 ==0 | num4Round2 == 0 | num4Round3 == 0) d = true; else d = false;
                    Console.WriteLine("d " + d);
                
                Console.ReadLine();
            }
        }
    }
}
