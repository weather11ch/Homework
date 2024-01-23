using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            Dentist d1 = new Dentist("Roman");
            Therapist t1 = new Therapist("Alexey");
            Surgeon s1 = new Surgeon("Anna");
            Patient p1 = new Patient("Peter", "Smit");
            Patient p2 = new Patient("Alexandr", "Green");
            Patient p3 = new Patient("Nikol", "Kidman");

            List<Doctor> doctors = new List<Doctor>()
            {
                d1, t1, s1
            };

            Patient[] patients = new Patient[3];
            patients[0] = p1;
            patients[1] = p2;
            patients[2] = p3;
 
            for (int i = 0; i < patients.Length; i++)
            {                
                {
                    patients[i].AppointPlan(patients[i].patientName, i);
                    if (patients[i].pN == 0) { s1.Treat(); }
                    else
                    {
                        if (patients[i].pN == 1) { d1.Treat(); }
                        else { t1.Treat(); }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
//Создать программу для имитации работы клиники.
//Пусть в клинике будет три врача: хирург, терапевт и дантист.
//Каждый врач имеет метод «лечить», но каждый врач лечит по-своему. Так же
//предусмотреть класс «Пациент» и класс «План лечения». Создать объект класса
//«Пациент» и добавить пациенту план лечения. Так же создать метод, который
//будет назначать врача пациенту согласно плану лечения.
//Если план лечения имеет код 1 – назначить хирурга и выполнить метод лечить.
//Если план лечения имеет код 2 – назначить дантиста и выполнить метод лечить.
//Если план лечения имеет любой другой код – назначить терапевта и выполнить метод лечить.
