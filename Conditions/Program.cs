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


            int age = 25;
            if(age >= 18)
            {
                Console.WriteLine("You are eligible for vote");
            }
            else
            {
                Console.WriteLine("You are not eligible for vote");
            }


            int marks = 50;

            if(marks >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if(marks >= 75)
            {
                Console.WriteLine("Grade B");           
            }
            else if(marks >= 50)
            {
                Console.WriteLine("Grade c");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            //loops
            Console.WriteLine("hi");


        }
    }
}
