using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionsdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int a = 1;
            //int b = 2;
            //int sum = a+ b;

            //int c = 3;
            //int d = 4;
            //int sum2 = c + d;

            //int e = 5;
            //int f = 6;
            //int sum3 = e + f;



            //GetSum(1, 2);
            //GetSum(3, 4);
            //GetSum(5, 6);
            //GetSum3();

            //decimal sum4 = GetSum2(5, 6);
            //Console.WriteLine(sum4);
            //Console.ReadLine();


            //Types
            //1. Pre defined
            //2. User defined


            //User defined types
            //1. parameterless
            //2. Parameters

            //Bill Calculator

            //Console.Write("Enter product name: ");
            //string product = Console.ReadLine();

            //Console.Write("Enter quantity: ");
            //int quantity = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter price per item: ");
            //double pricePerItem = Convert.ToDouble(Console.ReadLine());

            //double total = CalculateBill(quantity, pricePerItem);

            //PrintBill(product,quantity,pricePerItem, total);

            //Recursion-->calling method inside method.

            SayHello(6);

            //Factorial of number
            // 10! --> 10*9!--> 10*9*8!
            int fact = GetFactorial(10);
            Console.WriteLine(fact);

            // 0 1 1 2 3 5 8 13 21 34 --> Fibonacci series

            int Fibonacci(int n)
            {
                if (n == 0) return 0;
                if (n == 1) return 1;

                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }


        }


        public static int GetFactorial(int num)
        {
            if(num == 0)
            {
                return 0;
            }
            if(num == 1)
            {
                return 1;
            }
            return num * GetFactorial(num - 1);
        }

        public static void SayHello(int count)
        {
            if (count == 0)
            {
                return;
            }
            Console.WriteLine("Hello");
            SayHello(count - 1);
        }


        public static double CalculateBill(int quantity, double pricePerItem)
        {
            return quantity * pricePerItem;
        }

        public static void PrintBill(string product, int qty, double price, double total)
        {
            Console.WriteLine("\n----- BILL -----");
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quantity: " + qty);
            Console.WriteLine("Price per item: " + price);
            Console.WriteLine("Total: " + total);
        }

        //public static void GetSum(int a, int b, int c)
        //{
        //    Console.WriteLine($"Sum is: {a+b}");
        //}

        //public static decimal GetSum2(int a, int b) 
        //{ 
        //    return a + b;
        //}


        ////Parameterless method
        //public static void GetSum3()
        //{

        //}




    }
}
