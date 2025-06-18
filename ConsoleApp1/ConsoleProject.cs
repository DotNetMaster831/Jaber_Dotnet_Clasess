using System;

namespace ConsoleApp1
{
    public class ConsoleProject
    {
        //Billing System
        
        public static void PrintBillingSystem()
        {

            Console.WriteLine("Enter customer Name: "); //font color Red
            string customer = Console.ReadLine();            
            
            
            Console.WriteLine("Enter Product Name: "); //color yellow
            string product = Console.ReadLine();

            Console.WriteLine("Enter Quantity: "); // color is blue
            string quantity = Console.ReadLine();

            Console.WriteLine("Enter Price for each qty: "); //color is megenta
            string price = Console.ReadLine();



            //color Green
            Console.WriteLine($"Customer: {customer}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Qty: {quantity}");
            Console.WriteLine($"Price: {price}");

            //Beep Sound in the end

        }

    }
}
