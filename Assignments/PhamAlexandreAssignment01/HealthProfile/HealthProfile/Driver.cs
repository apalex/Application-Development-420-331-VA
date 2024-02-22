using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthProfile
{
    internal class Driver
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter your Last Name: ");
            String lastName = Console.ReadLine();
            Console.Write("Please Enter your First Name: ");
            String firstName = Console.ReadLine();
            Console.Write("Please Enter your Birth Year: ");
            int birthYear = int.Parse(Console.ReadLine());
            Console.Write("Please Enter your Height in Inches: ");
            int heightIn = int.Parse(Console.ReadLine());
            Console.Write("Please Enter your Weight in Pounds: ");
            int weightLbs = int.Parse(Console.ReadLine());
            Console.Write("Please Enter the Current Year: ");
            int currentYear = int.Parse(Console.ReadLine());
            HealthProfiles patient = new HealthProfiles(firstName, lastName, birthYear, heightIn, weightLbs, currentYear);
            patient.DisplayHealthRecord();
        }
    }
}
