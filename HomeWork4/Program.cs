using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{ 
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] createArray(int l, int num)
            {
                int[] r = new int[l];
                Random rnd = new Random();
                for (int i = 0; i < l; i++)
                {
                    r[i] = rnd.Next(num);
                    Console.Write(r[i] + " ");
                }
                return r;
            }
            void writeArray(int[] r)
            {
                for (int i = 0; i < r.Length; i++)
                {
                    Console.Write(r[i] + " ");
                }
            }
            void forth1()
            {
                Console.WriteLine("задайте длину одномерного массива");
                int l = Int32.Parse(Console.ReadLine());
                Console.WriteLine("задайте максимальное число диапазона значений массива");
                int n = Int32.Parse(Console.ReadLine());

                int[] r = createArray(l, n); Console.ReadLine();
                //1, 2, 3, 4
                int min = r[0]; int max = r[0]; int minIndex = 0; int maxIndex = 0;
                for (int i = 1; i < l; i++)
                {
                    if (r[i] < min) { min = r[i]; minIndex = i; }
                    if (r[i] > max) { max = r[i]; maxIndex = i; }
                }

                Console.WriteLine("min = " + min + " minIndex = " + minIndex);
                Console.WriteLine("max = " + max + " maxIndex = " + maxIndex);
                //5
                Console.ReadLine();
                int sum = 0;
                for (int i = 1; i<l;i = i+2)
                {
                    sum = sum + r[i];
                }
                Console.WriteLine("сумма нечетных элементов массива (с нечетными индексами) равна " + sum);
                Console.ReadLine();
                //6 реверс
                int temp = r[0]; int t;
                int[] res= new int[l]; 
                for (int i=0; i<l; i++) 
                {
                    t = l-1 - i;
                    res[t] = r[i];
                }
                Console.WriteLine("перевернутый массив");
                writeArray(res);
                //Console.ReadLine();
                //7
                int j = 0;
                for (int i = 0; i < l; i++)
                {
                    if (r[i] % 2 != 0) { j = j + 1; }
                }
                Console.WriteLine("количество нечетных элементов массива равно " + j);
                Console.ReadLine();

            }
            forth1();
        }
    }
}
