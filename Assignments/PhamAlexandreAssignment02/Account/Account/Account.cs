using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Account
    {
        private String accountNum;
        private decimal accountBal;
        private String lastName;
        private String firstName;

        public Account(String accountNum, decimal accountBal, String lastName, String firstName)
        {
            AccNumber = accountNum;
            Balance = accountBal;
            LastName = lastName;
            FirstName = firstName;
        }

        public String AccNumber
        {
            get
            {
                return accountNum;
            }
            set
            {
                accountNum = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return accountBal;
            }
            set
            {
                if (value < 0.0m)
                {
                    Console.WriteLine("Account initial balance amount should be a positive value.");
                }
                else
                {
                    accountBal = value;
                }
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

        public virtual void Credit(decimal amount)
        {
            if (amount >= 0.0m)
            {
                Balance += amount;
            } else
            {
                Console.WriteLine("Credit amount should be a non-negative value.");
            }
        }

        public virtual bool Debit(decimal amount)
        {
            if (amount >= 0.0m)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    return true;
                } else
                {
                    Console.WriteLine("Debit amount exceeded amount balance.");
                    return false;
                }
            } else
            {
                Console.WriteLine("Debit amount should be a non-negative value.");
                return false;
            }
        }

        public void DisplayAccount()
        {
            drawLine();
            Console.WriteLine($"| {"ACCOUNT",33}  {"|",25}");
            drawLine();
            Console.WriteLine($"| {"Account Number",-25} | {AccNumber,30} |");
            Console.WriteLine($"| {"Balance Amount",-25} | {$"${Balance}",30} |");
            Console.WriteLine($"| {"Last Name",-25} | {LastName,-30} |");
            Console.WriteLine($"| {"First Name",-25} | {FirstName,-30} |");
            drawLine();
        }

        public static void drawLine()
        {
            Console.Write("|");
            for (int i = 0; i < 60; i++)
                Console.Write("-");
            Console.WriteLine("|");
        }
    }
}
