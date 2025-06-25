using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If it rains, take umbrella. Else, go without umbrella.

            //True or False

            //if-else

            /*
             * if(condition)
             * {
             *      //code to execute
             * }
             */


            //int age = 25;
            //if(age >= 18)
            //{
            //    Console.WriteLine("You are eligible for vote");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible for vote");
            //}


            //int marks = 50;

            //if(marks >= 90)
            //{
            //    Console.WriteLine("Grade A");
            //}
            //else if(marks >= 75)
            //{
            //    Console.WriteLine("Grade B");           
            //}
            //else if(marks >= 50)
            //{
            //    Console.WriteLine("Grade c");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}

            ////loops
            //Console.WriteLine("hi");


            //Switch


            Console.WriteLine("Welcome to the calculator");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.exit");


            Console.WriteLine("Please enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());


            //if(choice == 1)
            //{

            //}
            //else if(choice == 2)
            //{

            //}
            //else if(choice == 3)
            //{

            //}
            //else
            //{

            //}

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Sum");
                    break;
                case 2:
                    Console.WriteLine("Sub");
                    break;
                case 3:
                    Console.WriteLine("exiting....");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }


        }
    }
}
