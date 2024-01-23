using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Therapist : Doctor
    {
        public Therapist(String name) : base(name) 
        {
            
        }
        public override void Treat()
        {
            Console.WriteLine("Therapist treats");
        }
    }
}
