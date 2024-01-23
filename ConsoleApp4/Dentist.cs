using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Dentist : Doctor
    {
        public String docName;
        public Dentist(String name) : base(name)
        {

        }
        public override void Treat()
        {
            Console.WriteLine("Dentist treats");
        }

    }
}
