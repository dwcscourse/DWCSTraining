using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        bool hasBackupAccount = false;

        //private List<Transaction> transactions { get; set; }

        private string owner;
        public string Owner 
        {
            get
            {
                return owner;
            }
        }
        private decimal balance;
        public decimal Balance 
        {
            get
            {
                return balance;
            }
        }

        private Account backupAccount;
        public Account BackupAccount
        {
            get
            {
                return backupAccount;
            }
            set 
            {
                this.backupAccount = value;
                hasBackupAccount = true;
            }
        }

        public Account(string name, decimal balance)
        {
            this.owner = name;
            this.balance = balance;
        }

        public bool Withdrawl(decimal withdrawlAmount)
        {
            bool isSuccessful = false;

            if (balance > withdrawlAmount)
            {
                balance -= withdrawlAmount;
                isSuccessful = true;
            }
            else if (hasBackupAccount == true && BackupAccount.Balance > withdrawlAmount)
            {
                isSuccessful = backupAccount.Withdrawl(withdrawlAmount);                 
            }
            else
            {
                Console.WriteLine("insufficient funds");
            }

            return isSuccessful;
        }
        public void Transfer(decimal transferAmount, Account receiverAccount)
        {
            if (balance < transferAmount)
            {
                Console.WriteLine("invalid transfer amount");
            }
            else
            {
                balance -= transferAmount;
                receiverAccount.Deposit(transferAmount);
            }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }
    }
}