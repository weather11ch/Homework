using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp4
{
    public class Patient
    {
        public String patientName;
        public int pN;
        public Patient(String name, String family ) 
        {
            patientName = family + " " + name;
        }        
        
        public  void AppointPlan(String patientName, int planNumber)
        {
            Console.WriteLine("Назначить пациенту " + patientName + " план лечения№ " + planNumber);
            pN = planNumber;

        } 
    }
}
