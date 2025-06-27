using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDEmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str1 = "Dotnetyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy";


            //// int, float etc    
            ////string                          

            //int i = 10;
            //double d = 20.5;

            //string str2 = "";
            //String str3;

            ////immutable and mutable any idea;
            ////strings are always immutable

            //int a = 5;
            //a = 6;

            //string str4 = "Dotnet";
            //str4 = "Tutorials";


            //string str = string.Empty;

            //Console.WriteLine("Loop started");

            //var stopwatch = new Stopwatch();

            //stopwatch.Start();


            //for(int i =0; i < 300000; i++)
            //{
            //    str = Guid.NewGuid().ToString();
            //}

            //stopwatch.Stop();

            //Console.WriteLine("Loop Ended");
            //Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);



            //string str2 = "";
            //Console.WriteLine("Loop Started");
            //var stopwatch2 = new Stopwatch();
            //stopwatch2.Start();
            //for (int i = 0; i < 30000; i++)
            //{
            //    str2 = "DotNet Tutorials" + str2;
            //}
            //stopwatch2.Stop();
            //Console.WriteLine("Loop Ended");
            //Console.WriteLine("Loop Exceution Time in MS :" + stopwatch2.ElapsedMilliseconds);

            //StringBuilder bb = new StringBuilder();
            //Console.WriteLine("Loop Started");
            //var stopwatch3 = new Stopwatch();
            //stopwatch3.Start();
            //for (int i = 0; i < 30000; i++)
            //{
            //    bb.Append("DotNet Tutorials");
            //}
            //stopwatch3.Stop();
            //Console.WriteLine("Loop Ended");
            //Console.WriteLine("Loop Exceution Time in MS :" + stopwatch3.ElapsedMilliseconds);



            ////1. String Concatenation

            //string fullName = "Durga" + "sai";

            //Console.WriteLine(fullName);

            ////2. String Length\
            //Console.WriteLine(fullName.Length);

            ////3. ToUpper & ToLower

            //Console.WriteLine(fullName.ToLower());
            //Console.WriteLine(fullName.ToUpper());

            ////4. Trims

            //string msg = "@#Hello##";

            //Console.WriteLine(msg);
            //Console.WriteLine(msg.Trim('#'));
            //Console.WriteLine(msg.TrimStart('#'));
            //Console.WriteLine(msg.TrimEnd('#'));

            //Console.WriteLine(msg.Contains("d"));
            //Console.WriteLine(msg.StartsWith("#"));
            //Console.WriteLine(msg.EndsWith("#"));

            //Console.WriteLine(msg.Replace("Hello", "Hi"));


            //Palindromes
            //"madam
            //level
            //racecar
            //12321"

            //check entered string is palindrome or not


            Console.Write("Enter a string: ");
            string input = Console.ReadLine();



            bool isPalindrome = true;

            for(int i = 0, j = input.Length-1; i < j; i++, j--)
            {
                if (input[i] != input[j])
                {
                    isPalindrome = false;
                    break;
                }
            }

            //string reversedString = ReverseString(input);

            if (isPalindrome)
                Console.WriteLine("✅ It is a palindrome.");
            else
                Console.WriteLine("❌ It is not a palindrome.");

            Console.ReadKey();

        }

        static string ReverseString(string str) //dotnetc "dotnet"
        {
            char[] charArray = str.ToCharArray(); //'d', 'o' , 't' , 'n' , 'e' , 't'
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
