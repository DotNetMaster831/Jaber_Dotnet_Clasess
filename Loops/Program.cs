using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string gg = "";
            String hh = "";

            /*
             * Loops are alo called as repeating statement or iterative statements
             */

            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");


            //For
            //for(initilization;Condition;increment/decrement){
            //statements
            //}

            //for(int i = 1; i <=100; i++)
            //{
            //    Console.Write(i+" ");
            //}

            //Console.WriteLine();

            //for(int i = 100; i >=1; i--)
            //{
            //    Console.Write(i+" ");
            //}

            //While loop
            //It will onlt takes care about condition
            //No intilization required, increment or decrement is required.

            //int i = 1;

            //while(i <= 3)
            //{
            //    Console.Write(i + " ");
            //    i++;
            //}


            ////do while

            //int j = 1;

            //do
            //{
            //    Console.Write(j + " ");
            //}while(j < 1);


            //Print how many even numbers are there in given range

            //Console.WriteLine("Please eneter the range:");
            //int range = Convert.ToInt32(Console.ReadLine());

            //// range 75
            //// i = 36 
            //for(int i = 0; i <= range; i++)
            //{
            //    //if(i == 35)
            //    //{
            //    //    continue;
            //    //}
            //    //if (i == 43)
            //    //{
            //    //    continue;
            //    //}
            //    if(i == 32)
            //    {
            //        break;
            //    }
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i + " Even number");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i + " Odd number");
            //    }
            //}


            //sum of first 100 numbers
            //1+2+3+4+5+.......+100

            //int sum = 0;

            //for(int i = 1; i <=100; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("the sum is " + sum);

            //Print 5 table with while loop

            //int i = 1;
            //while(i <= 20)
            //{
            //    Console.WriteLine($"5 X {i} = {5*i}");
            //    i++;
            //}

            //Ask user to enter password until it is admin

            string pass = "";

            while(pass != "admin")
            {
                Console.WriteLine("Enter the password:");
                pass = Console.ReadLine();
            }
            Console.WriteLine("Access GRANTED...");

        }
    }
}
