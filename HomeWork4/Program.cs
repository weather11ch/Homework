using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{ 
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] createArray(int l)
            {
                int[] r = new int[l];
                Random rnd = new Random();
                for (int i = 0; i <= l; i++)
                {
                    r[i] = rnd.Next(l);
                    Console.Write(r[i] + " ");
                }
                return r;
            }
            createArray(10);
        }
    }
}
