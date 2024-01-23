using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ConsoleApp4
{
    public class TreatmentPlan
    {
        public int planNumber;
        public String patientName;
        public int pN;
        
        public String name;
        public TreatmentPlan(int planNumber)
        {
            this.planNumber = planNumber;
        }

        public virtual void AppointPlan(String patientName, int planNumber)
        {
         
                Console.WriteLine("Назначить пациенту " + patientName + " план лечения " + planNumber);
            pN = planNumber; 
         
        }
    }
}
