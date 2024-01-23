using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Surgeon : Doctor
    {
        public Surgeon(String name) : base(name)
        {
            
        }
        public override void Treat()
        {
            Console.WriteLine("Surgeon treats");
        }
    }
}
