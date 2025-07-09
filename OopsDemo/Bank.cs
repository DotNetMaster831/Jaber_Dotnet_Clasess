using System;

namespace OopsDemo
{
    class Bank
    {
        public string nameOfTheBank;
        public string userName;
        public double accountNumber;
        public double Amount;


        public void PrintUserDetails()
        {
            Console.WriteLine($"Welcome to {nameOfTheBank}");
            Console.WriteLine($"User name is {userName}");
            Console.WriteLine($"User Account number is {accountNumber}");
            Console.WriteLine($"User balance : {Amount}");
        }

        public void Deposit(double amount)
        {
            Amount += amount;
            Console.WriteLine("Amount is deposited successfully");
        }

        public void Withdraw(double amount)
        {
            Amount -= amount;
            Console.WriteLine("Amount is withdrawn successfully");
        }

        public void CheckBlanace()
        {
            Console.WriteLine($"Your remaining balance is {Amount}");
        }

    }
}