using System;

namespace ConsoleApp1
{
    public class ConsoleProject
    {
        //Billing System
        
        public static void PrintBillingSystem()
        {

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Enter customer name: ");
            string customer = Console.ReadLine();

            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Enter product name: ");
            string product = Console.ReadLine();

            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Enter quantity: ");
            string quantity = Console.ReadLine();

            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Enter price for each qty: ");
            string price = Console.ReadLine();

            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Customer: {customer} ");
            Console.WriteLine($"Product: {product} ");
            Console.WriteLine($"Quantity: {quantity} ");
            Console.WriteLine($"Price: {price} ");

            Console.Beep();

            Console.ReadKey();


        }

    }
}
