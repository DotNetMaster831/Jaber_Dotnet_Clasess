using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Person p1 = new Person();
            //p1.Name = "Durga";
            //p1.Gender = "Male";
            //p1.Age = 28;

            //Person p2 = new Person();
            //p2.Name = "Jaber";
            //p2.Gender = "Male";
            //p2.Age = 22;

            //Person p3 = new Person();
            //p3.Name = "Bindu";
            //p3.Gender = "Female";
            //p3.Age = 28;

            //Person p4;
            //Person p5;

            Bank bank1 = new Bank();
            bank1.nameOfTheBank = "SBI";
            bank1.userName = "jaber";
            bank1.accountNumber = 123456;
            bank1.Amount = 1000;

            bank1.PrintUserDetails();
            bank1.Deposit(5000);
            bank1.Withdraw(2000);
            bank1.CheckBlanace();

            Console.WriteLine();

            Bank bank2 = new Bank();
            bank2.nameOfTheBank = "Bank of America";
            bank2.userName = "Durga";
            bank2.accountNumber = 123456;
            bank2.Amount = 2000;
                
            bank2.PrintUserDetails();
            bank2.Deposit(2000);
            bank2.Withdraw(3000);
            bank2.CheckBlanace();


            Console.WriteLine();

            Book b1 = new Book();
            b1.Title = "Rich dad Poor dad";
            b1.Author = "Dotnet";
            b1.Price = 100;
            b1.ISBN = "123456";
            b1.PrintBookInfo();

            Book b2 = new Book();
            b2.Title = "Rich dad Poor dad";
            b2.Author = "Dotnet";
            b2.Price = 100;
            b2.ISBN = "123456";
            b2.PrintBookInfo();

        
        }
    }
}
