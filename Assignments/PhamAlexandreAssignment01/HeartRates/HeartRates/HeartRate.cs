using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRates
{
    internal class HeartRate
    {
            private String firstName;
            private String lastName;
            private int birthYear;
            private int currentYear;

            // Constructor
            public HeartRate(String firstName, String lastName, int birthYear, int currentYear)
            {
                FirstName = firstName;
                LastName = lastName;
                BirthYear = birthYear;
                CurrentYear = currentYear;
            }

            // Getters and Setters
            public String FirstName
            {
                get {
                    return firstName;
                }

                set {
                    firstName = value;
                }
            }

            public String LastName
            {
                get
                {
                    return lastName;
                }

                set
                {
                    lastName = value;
                }
            }

            public int BirthYear
            {
                get
                {
                    return birthYear;
                }

                set
                {
                    birthYear = value;
                }
            }

            public int CurrentYear
            {
                get
                {
                    return currentYear;
                }

                set 
                {
                    currentYear = value;
                }
            }

            // Age Calculator
            public int CurrentAge
            {
                get
                {
                    return CurrentYear - BirthYear;
                }
            }

            // Maximum Heart Rate Calculator
            public int MaximumHeartRate
            { 
                get
                {
                    return 220 - CurrentAge;
                }
            }

            // Minimum and Maximum Target Heart Rates
            public int TargetMaximum
            {
                get 
                {
                    return Convert.ToInt16(MaximumHeartRate * 0.85);
                }
            }

            public int TargetMinimum
            {
                get
                {
                    return Convert.ToInt16(MaximumHeartRate * 0.5);
                }
            }

            public void DisplayPatientRecord()
            {
                drawLine();
                Console.WriteLine($"| {"PATIENT HEART RATE RECORD", 53}  {"|", 25}");
                drawLine();
                Console.WriteLine($"| {"Patient Name", -35} | {$"{LastName}, {FirstName}", -40} |");
                Console.WriteLine($"| {"Patient Birth Year", -35} | {BirthYear, 40} |");
                Console.WriteLine($"| {"Patient Age", -35} | {CurrentAge, 40} |");
                Console.WriteLine($"| {"Maximum Heart Rate", -35} | {MaximumHeartRate, 40} |");
                Console.WriteLine($"| {"Target Heart Rate Range", -35} | {TargetMinimum, 36}-{TargetMaximum} |");
                drawLine();
            }


            public static void drawLine()
            {
                Console.Write("|");
                for (int i = 0; i < 80; i++)
                    Console.Write("-");
                Console.WriteLine("|");
            }
        }
    }

