using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Doctor
    {
        public String name;
        public String docType;
        public Doctor(String name)
        {
            this.name = name;
        }
        public virtual void Treat()
        {
            Console.WriteLine("Doctor treats " + name);
        }
        public virtual void Treat(int TreatmentPlan)
        {
            if (TreatmentPlan == 0) { 
            Console.WriteLine("Doctor dentist " + name + " treats by plan " + TreatmentPlan);
            }
            if (TreatmentPlan == 1)
            {
                Console.WriteLine("Doctor therapist " + name + " treats by plan " + TreatmentPlan);
            }
            if (TreatmentPlan == 2)
            {
                Console.WriteLine("Doctor surgeon " + name + " treats by plan " + TreatmentPlan);
            }
        }        
    }
}
