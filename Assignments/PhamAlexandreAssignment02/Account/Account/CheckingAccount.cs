using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class CheckingAccount : Account
    {
        private decimal transactionFee;

        public CheckingAccount(decimal transactionFee, String accountNum, decimal accountBal, String lastName, String firstName) : base(accountNum, accountBal, lastName, firstName)
        {
            TransactionFee = transactionFee;
        }

        public decimal TransactionFee
        {
            get
            {
                return transactionFee;
            }
            set
            {
                if (value < 0)
                {
                    transactionFee = 1.5m;
                    Console.WriteLine("Transaction fee should be a positive value.");
                }
                else
                {
                    transactionFee = value;
                }
            }
        }

        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance -= TransactionFee;
        }

        public override bool Debit(decimal amount)
        {
            bool flag = base.Debit(amount);
            if (flag)
            {
                Balance -= TransactionFee;
            }
            return flag;
        }

        public new void DisplayAccount()
        {
            drawLine();
            Console.WriteLine($"| {"CHECKING ACCOUNT",33}  {"|",25}");
            drawLine();
            Console.WriteLine($"| {"Account Number",-25} | {AccNumber,-30} |");
            Console.WriteLine($"| {"Balance Amount",-25} | {$"${Balance}",30} |");
            Console.WriteLine($"| {"Last Name",-25} | {LastName,-30} |");
            Console.WriteLine($"| {"First Name",-25} | {FirstName,-30} |");
            Console.WriteLine($"| {"Transaction Fee",-25} | {$"${TransactionFee}",30} |");
            drawLine();
        }
    }
}
