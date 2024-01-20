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
            //forth1();
            //forth2();
            //forth3()
            //forth4();
            //forth5();
            //forth6();
            //forth7();
            forth8();
            Console.ReadLine();
        }
        
         static int[] createArray(int l, int num)
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
        static void writeArray(int[] r)
        {
            for (int i = 0; i < r.Length; i++)
            {
                Console.Write(r[i] + " ");
            }
        }
        static void forth1()
        //1.	Найти минимальный элемент массива
        {
            Console.WriteLine("задайте длину одномерного массива");
            int l = Int32.Parse(Console.ReadLine());
            Console.WriteLine("задайте максимальное число диапазона значений массива");
            int n = Int32.Parse(Console.ReadLine());

            int[] r = createArray(l, n);
            
            int min = r[0]; int minIndex = 0;
            for (int i = 1; i < l; i++)
            {
                if (r[i] < min) { minIndex = i; }
                
            }                       
            Console.WriteLine("min = " + r[minIndex]);
            
        }
        static void forth2()
            //2.	Найти максимальный элемент массива
        {
            Console.WriteLine("задайте длину одномерного массива");
            int l = Int32.Parse(Console.ReadLine());
            Console.WriteLine("задайте максимальное число диапазона значений массива");
            int n = Int32.Parse(Console.ReadLine());

            int[] r = createArray(l, n);
            int max = r[0]; int maxIndex = 0;
            for (int i = 1; i < l; i++)
            {                
                if (r[i] > max) {maxIndex = i; }
            }

            Console.WriteLine("max = " + r[maxIndex]);
        }
        static void forth3()
        //3.	Найти индекс минимального элемента массива
        {
            Console.WriteLine("задайте длину одномерного массива");
            int l = Int32.Parse(Console.ReadLine());
            Console.WriteLine("задайте максимальное число диапазона значений массива");
            int n = Int32.Parse(Console.ReadLine());

            int[] r = createArray(l, n);
            
            int min = r[0]; int minIndex = 0; 
            for (int i = 1; i < l; i++)
            {
                if (r[i] < min) {minIndex = i; }                
            }

            Console.WriteLine(" minIndex = " + minIndex);           
            
        }
        static void forth4()
        //4.	Найти индекс максимального элемента массива
        {
            Console.WriteLine("задайте длину одномерного массива");
            int l = Int32.Parse(Console.ReadLine());
            Console.WriteLine("задайте максимальное число диапазона значений массива");
            int n = Int32.Parse(Console.ReadLine());

            int[] r = createArray(l, n);
           
            int max = r[0]; int maxIndex = 0;
            for (int i = 1; i < l; i++)
            {               
                if (r[i] > max) { maxIndex = i; }
            }

            Console.WriteLine(" maxIndex = " + maxIndex);
        }

        static void forth5()
        //5.	Посчитать сумму элементов массива с нечетными индексами
        {
            Console.WriteLine("задайте длину одномерного массива");
            int l = Int32.Parse(Console.ReadLine());
            Console.WriteLine("задайте максимальное число диапазона значений массива");
            int n = Int32.Parse(Console.ReadLine());

            int[] r = createArray(l, n);

            int sum = 0;
            for (int i = 1; i < l; i = i + 2)
            {
                sum = sum + r[i];
            }
            Console.WriteLine("сумма нечетных элементов массива (с нечетными индексами) равна " + sum);
        }
        static void forth6()
        //6.	Сделать реверс массива (массив в обратном направлении)
        {
            Console.WriteLine("задайте длину одномерного массива");
            int l = Int32.Parse(Console.ReadLine());
            Console.WriteLine("задайте максимальное число диапазона значений массива");
            int n = Int32.Parse(Console.ReadLine());

            int[] r = createArray(l, n);

            int temp = r[0]; 
            int[] res = new int[l];
            for (int i = 0; i < l/2; i++)
            {
                temp = r[i];
                r[i] = r[l - i-1]; 
                r[l - i - 1] = temp;
            }
            Console.WriteLine();
            Console.WriteLine("перевернутый массив реверс");
            writeArray(r);
        }
        static void forth7()
        //7.	Посчитать количество нечетных элементов массива
        {
            Console.WriteLine("задайте длину одномерного массива");
            int l = Int32.Parse(Console.ReadLine());
            Console.WriteLine("задайте максимальное число диапазона значений массива");
            int n = Int32.Parse(Console.ReadLine());

            int[] r = createArray(l, n);
            int j = 0;
            for (int i = 0; i < l; i++)
            {
                if (r[i] % 2 != 0) { j = j + 1; }
            }
            Console.WriteLine("количество нечетных элементов массива равно " + j);            

        }

        static void forth8()
        //8.	Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
        {
            Console.WriteLine("задайте длину одномерного массива");
            int l = Int32.Parse(Console.ReadLine());
            Console.WriteLine("задайте максимальное число диапазона значений массива");
            int n = Int32.Parse(Console.ReadLine());
            int t;
            int[] r = createArray(l, n);
            int[] res = new int[l];
            int m;
            if (l % 2 == 0)
            {
                m = (l - 1) / 2;
            }
            else { m = (l - 1) / 2 - 1; res[(l - 1) / 2] = r[(l - 1) / 2]; }

            for (int i = 0; i <= m; i++)
            {
                t = (l - 1) / 2 + 1 + i;
                res[t] = r[i];
                res[i] = r[t];

            }

            Console.WriteLine("перевернутый массив");
            writeArray(res);
        }

        void forth9()
        //9.	Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble), выбором (Select) или вставками (Insert)) 
        {
            Console.WriteLine("задайте длину одномерного массива");
            int l = Int32.Parse(Console.ReadLine());
            Console.WriteLine("задайте максимальное число диапазона значений массива");
            int n = Int32.Parse(Console.ReadLine());

            int[] r = createArray(l, n);
            int temp = r[0]; int t;
            int[] res = new int[l];

            for (int i = 0; i < l; i++)
            {

            }
        }


    }
}
