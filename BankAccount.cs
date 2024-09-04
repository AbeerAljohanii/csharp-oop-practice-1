using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_oop_practice_1
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public string AccountNumber { get; set; }
        private double _balance;
        private static Random _random = new Random();

        public BankAccount(string accountHolder, double initialDeposit)
        {
            AccountHolder = accountHolder;
            _balance = initialDeposit;
            AccountNumber = GenerateAccountNumber();
        }

        private string GenerateAccountNumber()
        {
            String startWith = "ACC";
            return startWith + _random.Next(1000, 9999);
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Successfully deposited ${amount}. New balance: ${_balance}");
                return;
            }
            Console.WriteLine("Invalid deposit amount");
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"Successfully withdrew ${amount}. New balance: ${_balance}");
                return;
            }
            Console.WriteLine("Invalid withdraw amount. Please ensure you have sufficient funds.");
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: ${_balance}");
        }
    }
}
