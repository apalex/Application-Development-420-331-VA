using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthProfile
{
    internal class HealthProfiles
    {
            private String firstName;
            private String lastName;
            private int birthYear;
            private int heightIn;
            private int weightLbs;
            private int currentYear;

            // Constructor
            public HealthProfiles(string firstName, string lastName, int birthYear, int heightIn, int weightLbs, int currentYear)
            {
                FirstName = firstName;
                LastName = lastName;
                BirthYear = birthYear;
                HeightIn = heightIn;
                WeightLbs = weightLbs;
                CurrentYear = currentYear;
            }

            // Getter and Setters
            public String FirstName
            {
                get 
                { 
                    return firstName;
                }
                set
                {
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

            public int HeightIn
            {
                get
                {
                    return heightIn;
                }

                set 
                {
                    heightIn = value;
                }
            }

            public int WeightLbs
            {
                get
                {
                    return weightLbs;
                }
                set
                {
                    weightLbs = value;
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

            // Calculate Age
            public int CalculateAge
            {
                get
                {
                    return CurrentYear - BirthYear;
                }
            }

            // Maximum Heart Rate
            public int MaximumHeartRate
            {
                get
                {
                    return 220 - CalculateAge;
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

            // Calculate BMI
            public double CalculateBmi(int weightLbs, int heightIn)
            {
                return Math.Round((double)(weightLbs * 703) / (double)(heightIn * heightIn), 1);
            }

            // Calculate BMI Text Values
            public String CalculateBMIText(double bmiVal)
            {
                if (bmiVal < 18.5)
                {
                    return "Underweight";
                } else if (bmiVal >= 18.5 && bmiVal <= 24.9)
                {
                    return "Normal";
                } else if (bmiVal >= 25 && bmiVal <= 29.9)
                {
                    return "Overweight";
                } else
                {
                    return "Obese";
                }
            }

            public void DisplayHealthRecord()
            {
                drawLine();
                Console.WriteLine($"| {"PATIENT HEALTH RECORD", 53}  {"|", 25}");
                drawLine();
                Console.WriteLine($"| {"Patient Name",-35} | {$"{LastName}, {FirstName}",-40} |");
                Console.WriteLine($"| {"Patient Birth Year",-35} | {BirthYear,40} |");
                Console.WriteLine($"| {"Patient Age",-35} | {CalculateAge,40} |");
                Console.WriteLine($"| {"Patient Height",-35} | {HeightIn,40} |");
                Console.WriteLine($"| {"Patient Weight",-35} | {WeightLbs,40} |");
                Console.WriteLine($"| {"Maximum Heart Rate",-35} | {MaximumHeartRate,40} |");
                Console.WriteLine($"| {"Target Heart rate Range",-35} | {TargetMinimum, 36}-{TargetMaximum} |");
                Console.WriteLine($"| {"BMI Numeric Value",-35} | {CalculateBmi(WeightLbs, HeightIn),40} |");
                Console.WriteLine($"| {"BMI Text Value",-35} | {CalculateBMIText(CalculateBmi(WeightLbs, HeightIn)),-40} |");
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

