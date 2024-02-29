using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Driver
    {
        static void Main(string[] args)
        {

            Console.Write("Please Enter your Savings Account Number: ");
            String accountNum = Console.ReadLine();
            Console.Write("Please Enter your Savings Account Balance: ");
            decimal accountBal = decimal.Parse(Console.ReadLine());
            Console.Write("Please Enter your Last Name: ");
            String lastName = Console.ReadLine();
            Console.Write("Please Enter your First Name: ");
            String firstName = Console.ReadLine();
            Console.Write("Please Enter your Savings Account Interest Rate: ");
            decimal interestRate = decimal.Parse(Console.ReadLine());
            Console.Write("Please Enter your Savings Account Transaction Fee: ");
            decimal transactionFee = decimal.Parse(Console.ReadLine());

            // Savings Account

            SavingsAccount savings = new SavingsAccount(interestRate, accountNum, accountBal, lastName, firstName);

            // Before Interest
            Console.WriteLine("Savings Account Information Before Interest");
            savings.DisplayAccount();

            // After Interest
            decimal interest = savings.CalculateInterest();
            savings.Credit(interest);
            Console.WriteLine("Savings Account Information After Interest");
            savings.DisplayAccount();

            // Credit
            Console.Write("Enter the amount to credit to the Savings Account: ");
            decimal credit = decimal.Parse(Console.ReadLine());
            savings.Credit(credit);
            Console.WriteLine("Savings Account after Credit Transaction:");
            savings.DisplayAccount();

            // Debit
            Console.Write("Enter the amount to debit to the Savings Account: ");
            decimal debit = decimal.Parse(Console.ReadLine());
            savings.Debit(debit);
            Console.WriteLine("Savings Account After Debit Transaction:");
            savings.DisplayAccount();

            // Checkings Account
            Console.Write("Please Enter your Checkings Account Number: ");
            String checkingsNum = Console.ReadLine();
            Console.Write("Please Enter your Checkings Account Balance: ");
            decimal checkingsBal = decimal.Parse(Console.ReadLine());

            CheckingAccount checkings = new CheckingAccount(transactionFee, checkingsNum, checkingsBal, lastName, firstName);
            Console.WriteLine("Checkings Account");
            checkings.DisplayAccount();

            // Credit
            Console.Write("Enter the amount to credit to the Checkings Account: ");
            decimal creditCheckings = decimal.Parse(Console.ReadLine());
            checkings.Credit(creditCheckings);
            Console.WriteLine("Checkings Account after Credit Transaction:");
            checkings.DisplayAccount();

            // Debit
            Console.Write("Enter the amount to debit to the Checkings Account: ");
            decimal debitCheckings = decimal.Parse(Console.ReadLine());
            checkings.Debit(debitCheckings);
            Console.WriteLine("Checkings Account After Debit Transaction:");
            checkings.DisplayAccount();
        }
    }
}
