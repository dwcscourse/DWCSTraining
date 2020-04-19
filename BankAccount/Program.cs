using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To create your bank account, type your name and amount of money: ");
            string name = Console.ReadLine();
            decimal amountAccount = decimal.Parse(Console.ReadLine());
            Account primaryAccount = new Account(name, amountAccount);

            Console.WriteLine("To create а backup account just enter starting balance");
            decimal amountBackupAccount = decimal.Parse(Console.ReadLine());
            Account backupAccount = new Account(name, amountBackupAccount);
            primaryAccount.BackupAccount = backupAccount;

            

            decimal amount = 0;


            bool shouldContinue = true;
            while (shouldContinue)
            {
                shouldContinue = false;
                Console.WriteLine("Please choose what you want to do: \n" +
                "for deposit, press 1, \n" +
                "for withdrawl, press 2, \n" +
                "to transfer money from the Primary to the Backup account, press 3, \n" +
                "to transfer money from the Backup to the Primary account, press 4, \n" +
                "for exit, press 9");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter amount of deposit: ");
                        amount = decimal.Parse(Console.ReadLine());
                        primaryAccount.Deposit(amount);
                        shouldContinue = true;
                        break;
                    case 2:
                        Console.WriteLine("Enter amount of withdrawal: ");
                        amount = decimal.Parse(Console.ReadLine());
                        primaryAccount.Withdrawl(amount);
                        shouldContinue = true;
                        break;
                    case 3:
                        Console.WriteLine("Enter amount to be transferred: ");
                        amount = decimal.Parse(Console.ReadLine());
                        primaryAccount.Transfer(amount, backupAccount);
                        shouldContinue = true;
                        break;
                    case 4:
                        Console.WriteLine("Enter amount to be transferred: ");
                        amount = decimal.Parse(Console.ReadLine());
                        backupAccount.Transfer(amount, primaryAccount);
                        shouldContinue = true;
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("Please, choose 1, 2, 3 0r 4 to continue or 9 to exit");
                        shouldContinue = true;
                        break;
                }
            }

            Console.WriteLine($"The balance of {primaryAccount.Owner}'s Primary account is {primaryAccount.Balance}");
            Console.WriteLine($"The balance of {backupAccount.Owner}'s Backup account is {backupAccount.Balance} ");

        }
    }
}
