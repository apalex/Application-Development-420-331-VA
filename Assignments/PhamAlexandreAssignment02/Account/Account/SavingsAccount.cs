using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class SavingsAccount : Account
    {
        private decimal interestRate;

        public SavingsAccount(decimal interestRate, String accountNum, decimal accountBal, String lastName, String firstName) : base(accountNum, accountBal, lastName, firstName)
        {
            InterestRate = interestRate;
        }

        public decimal InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                if (value < 0)
                {
                    interestRate = 5;
                    Console.WriteLine("Interest rate should be a positive value");
                }
                else
                {
                    interestRate = value;
                }
            }
        }

        public decimal CalculateInterest()
        {
            return Math.Round((Balance * interestRate) / 100, 2);
        }

        public new void DisplayAccount()
        {
            drawLine();
            Console.WriteLine($"| {"SAVING ACCOUNT",33}  {"|",25}");
            drawLine();
            Console.WriteLine($"| {"Account Number",-25} | {AccNumber,30} |");
            Console.WriteLine($"| {"Balance Amount",-25} | {$"${Balance}",30} |");
            Console.WriteLine($"| {"Last Name",-25} | {LastName,-30} |");
            Console.WriteLine($"| {"First Name",-25} | {FirstName,-30} |");
            Console.WriteLine($"| {"Interest Rate",-25} | {$"${InterestRate}",30} |");
            Console.WriteLine($"| {"Interest Amount",-25} | {$"${CalculateInterest()}",30} |");
            drawLine();
        }
    }
}
