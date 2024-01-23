using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Square
    {
        public String col;
        public int a;
        public int s;
        public Square(int a, String col)
        {
            this.a = a;
            this.col = col;
            s = a * a;
        }
        public virtual void AboutSqaure()
        {
            Console.WriteLine(col + " квадрат со стороной " + a + " и площадью " + s);
        }
    }
}