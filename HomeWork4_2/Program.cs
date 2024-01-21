using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k;
            Console.WriteLine("Введите номер задачи (от 1 до 10)");
            k = Int32.Parse(Console.ReadLine());
            switch (k)
            {
                case 1: Forth2_1(); break;
                    case 2: Forth2_2(); break;
                    case 3: Forth2_3(); break;
                    case 4: Forth2_4(); break;
                    case 5: Forth2_5(); break;
                    //case 6: Forth2_6(); break;
                    //case 7: Forth2_7(); break;
                    //case 8: Forth2_8(); break;
                    //case 9: Forth2_9(); break;
                    //case 10: Forth2_10(); break;
            }
            Console.ReadLine();
        }
        static int[,] createArray(int l, int m, int num)
        {
            int[,] r = new int[l, m];
            Random rnd = new Random();
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    r[i, j] = rnd.Next(num);
                    Console.Write(r[i, j] + " ");
                }
                Console.WriteLine();
            }
            return r;
        }
        static void writeArray(int[,] r)
        {
            for (int i = 0; i < r.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < r.Length; j++)
                {
                    Console.Write(r[i, j] + " ");
                }
            }
        }
        static void Forth2_1()
        //1.	Найти минимальный элемент массива
        {
            Console.WriteLine("задайте размерность двумерного массива");
            int l = Int32.Parse(Console.ReadLine());
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("задайте максимальное число диапазона значений массива");
            int n = Int32.Parse(Console.ReadLine());

            int[,] massiv = createArray(l, m, n);

            int minIndexI = 0; int minIndexJ = 0;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ;
                    if (massiv[i, j] < massiv[minIndexI, minIndexJ]) { minIndexI = i; minIndexJ = j; }
                }
            }
            Console.WriteLine("min = " + massiv[minIndexI, minIndexJ]);

        }
        static void Forth2_2()
        //2.	Найти максимальный элемент массива
        {
            Console.WriteLine("задайте размерность двумерного массива");
            int l = Int32.Parse(Console.ReadLine());
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("задайте максимальное число диапазона значений массива");
            int n = Int32.Parse(Console.ReadLine());

            int[,] massiv = createArray(l, m, n);

            int maxIndexI = 0; int maxIndexJ = 0;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ;
                    if (massiv[i, j] > massiv[maxIndexI, maxIndexJ]) { maxIndexI = i; maxIndexJ = j; }
                }
            }
            Console.WriteLine("max = " + massiv[maxIndexI, maxIndexJ]);

        }
        static void Forth2_3()
        //3.	Найти индекс минимального элемента массива
        {
            Console.WriteLine("задайте размерность двумерного массива");
            int l = Int32.Parse(Console.ReadLine());
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("задайте максимальное число диапазона значений массива");
            int n = Int32.Parse(Console.ReadLine());

            int[,] massiv = createArray(l, m, n);

            int minIndexI = 0; int minIndexJ = 0;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (massiv[i, j] < massiv[minIndexI, minIndexJ]) { minIndexI = i; minIndexJ = j; }

                }
            }
            Console.WriteLine("minIndexI = " + minIndexI + " minIndexJ = " + minIndexJ);
        }
        static void Forth2_4()
        //4.	Найти индекс максимального элемента массива
        {
            Console.WriteLine("задайте размерность двумерного массива");
            int l = Int32.Parse(Console.ReadLine());
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("задайте максимальное число диапазона значений массива");
            int n = Int32.Parse(Console.ReadLine());

            int[,] massiv = createArray(l, m, n);

            int maxIndexI = 0; int maxIndexJ = 0;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (massiv[i, j] > massiv[maxIndexI, maxIndexJ]) { maxIndexI = i; maxIndexJ = j; }

                }
            }
            Console.WriteLine("maxIndexI = " + maxIndexI + " maxIndexJ = " + maxIndexJ);
        }
        static void Forth2_5()
        //5.	Найти количество элементов массива, которые больше всех своих соседей одновременно
        {
            Console.WriteLine("задайте размерность двумерного массива");
            int l = Int32.Parse(Console.ReadLine());
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("задайте максимальное число диапазона значений массива");
            int n = Int32.Parse(Console.ReadLine());

            int[,] massiv = createArray(l, m, n);

            int IndexI; int IndexJ;

            int count = 0;

            for (int i = 1; i < l-1; i++)
            {
                for (int j = 1; j < m-1; j++)
                {
                    if (massiv[i, j] > massiv[i, j+1] &
                        massiv[i, j] > massiv[i + 1, j] &
                        massiv[i, j] > massiv[i + 1, j + 1] &
                        massiv[i, j] > massiv[i - 1, j] &
                        massiv[i, j] > massiv[i - 1, j - 1] &
                        massiv[i, j] > massiv[i - 1 , j + 1] &
                        massiv[i, j] > massiv[i , j - 1] &
                        massiv[i, j] > massiv[i + 1, j - 1] ) 
                    { Console.WriteLine(massiv[i, j] + "  IndexI " + i + "  IndexJ =" + j); count++; }

                }
            }
            //1 line
            int t = 0;
            for (int j = 0; j < m; j++)
            {
                if (j == 0) {
                    if (massiv[t, j] > massiv[t, j + 1] &
                            massiv[t, j] > massiv[t + 1, j] &
                            massiv[t, j] > massiv[t + 1, j + 1])
                    {
                        count++;
                        Console.WriteLine(massiv[t, j] + "  IndexI " + t + "  IndexJ =" + j);
                    } }
                else
                {
                    if (j == m - 1)
                    {
                        if (massiv[t, j] > massiv[t + 1, j] &
                            massiv[t, j] > massiv[t, j - 1] &
                            massiv[t, j] > massiv[t + 1, j - 1])
                        {
                            count++;
                            Console.WriteLine(massiv[t, j] + "  IndexI " + t + "  IndexJ =" + j);
                        }
                    } else
                    {
                        if (massiv[t, j] > massiv[t , j - 1] &
                            massiv[t, j] > massiv[t, j + 1] &
                            massiv[t, j] > massiv[t + 1, j] &
                            massiv[t,j] > massiv[t+1, j - 1] &
                            massiv[t, j] > massiv[t + 1, j + 1])
                        {
                            count++;
                            Console.WriteLine(massiv[t, j] + "  IndexI " + t + "  IndexJ =" + j);
                        }
                    }
                }
            }
            //last line
            int last = l - 1;
            for (int j = 0; j < m; j++)
            {
                if (j == 0)
                {
                    if (massiv[last, j] > massiv[last, j + 1] &
                            massiv[last, j] > massiv[last - 1, j] &
                            massiv[last, j] > massiv[last - 1, j + 1])
                    {
                        count++;
                        Console.WriteLine(massiv[last, j] + "  IndexI " + last + "  IndexJ =" + j);
                    }
                }
                else
                {
                    if (j == m - 1)
                    {
                        if (massiv[last, j] > massiv[last - 1, j] &
                            massiv[last, j] > massiv[last, j - 1] &
                            massiv[last, j] > massiv[last - 1, j - 1])
                        {
                            count++;
                            Console.WriteLine(massiv[last, j] + "  IndexI " + last + "  IndexJ =" + j);
                        }
                    }
                    else
                    {
                        if (massiv[last, j] > massiv[last, j - 1] &
                            massiv[last, j] > massiv[last, j + 1] &
                            massiv[last, j] > massiv[last - 1, j] &
                            massiv[last, j] > massiv[last - 1, j - 1] &
                            massiv[last, j] > massiv[last - 1, j + 1])
                        {
                            count++;
                            Console.WriteLine(massiv[last, j] + "  IndexI " + last + "  IndexJ =" + j);
                        }
                    }
                }
            }
            //1 column
            int ct = 0;
            for (int i = 1; i < l-1; i++)
            {               
                        if (massiv[i, ct] > massiv[i, ct + 1] &
                            massiv[i, ct] > massiv[i + 1, ct + 1] &
                            massiv[i, ct] > massiv[i + 1, ct] &
                            massiv[i, ct] > massiv[i - 1, ct] &
                            massiv[i, ct] > massiv[i - 1, ct + 1])
                        {

                            count++; 
                            Console.WriteLine(massiv[i, ct] + "  IndexI " + i + "  IndexJ =" + ct);
                        }
                    
            }
            //last column
            int ctl = m - 1;
            for (int i = 1; i < l-1; i++)
            {                
                        if (massiv[i, ctl] > massiv[i, ctl - 1] &
                            massiv[i, ctl] > massiv[i + 1, ctl - 1] &
                            massiv[i, ctl] > massiv[i + 1, ctl] &
                            massiv[i, ctl] > massiv[i - 1, ctl] &
                            massiv[i, ctl] > massiv[i - 1, ctl - 1])
                        {
                            count++;
                            Console.WriteLine(massiv[i, ctl] + "  IndexI " + i + "  IndexJ =" + ctl);
                        }
                   
            }


            Console.WriteLine("количество элементов массива, которые больше всех своих соседей одновременно " + count);



        }
    } 
}
