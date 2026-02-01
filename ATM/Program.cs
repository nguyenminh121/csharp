using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM!\n");
            Console.WriteLine("Please providing your information");
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your account number:");
            string accountNumber = Console.ReadLine();
            Console.WriteLine("Enter your first balance:");
            double balance = double.Parse(Console.ReadLine());
            Console.WriteLine("Please select an option:\n");
            Console.WriteLine("1. Withdraw\n2. Deposit\n3. View Balance\n");
            int options;
            Console.WriteLine("Please select an option:");
            options = int.Parse(Console.ReadLine());
            switch (options)
            {
                case 1:
                    Console.WriteLine("Withdraw");
                    double withdrawAmount;
                    Console.WriteLine("Enter amount to withdraw:");
                    withdrawAmount = double.Parse(Console.ReadLine());
                    if (withdrawAmount > balance)
                    {
                        Console.WriteLine("Insufficient funds.");
                    }
                    else
                    {
                        balance -= withdrawAmount;
                        Console.WriteLine("Withdrawal successful. New balance: " + balance);
                    }
                    Console.WriteLine("Your current balance is: " + balance);
                    break;
                case 2:
                    Console.WriteLine("Deposit");
                    double depositAmount;
                    Console.WriteLine("Enter amount to deposit:");
                    depositAmount = double.Parse(Console.ReadLine());
                    balance += depositAmount;
                    Console.WriteLine("Deposit successful. New balance: " + balance);
                    break;
                default:
                    Console.WriteLine("View Balance");
                    Console.WriteLine("Your current balance is: " + balance);
                    break;
            }
        }
    }
}
