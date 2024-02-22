using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRates
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter your Last Name: ");
            String lastName = Console.ReadLine();
            Console.Write("Please Enter your First Name: ");
            String firstName = Console.ReadLine();
            Console.Write("Please Enter your Birth Year: ");
            int birthYear = int.Parse(Console.ReadLine());
            Console.Write("Please Enter your Current Year: ");
            int currentYear = int.Parse(Console.ReadLine());
            HeartRate patient = new HeartRate(firstName, lastName, birthYear, currentYear);
            patient.DisplayPatientRecord();
        }
    }
}
