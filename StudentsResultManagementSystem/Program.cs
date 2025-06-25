using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace StudentsResultManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Student name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Marks 1: ");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Marks 2: ");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Marks 3: ");
            int m3 = Convert.ToInt32(Console.ReadLine());


            int total = CalculateTotalMarks(m1, m2, m3);
            double avg = CalculateAverage(total, 3);
            string grade = GetGrade(avg);

            PrintResult(name, m1, m2, m3,total, avg, grade);




        }

        public static int CalculateTotalMarks(int m1, int m2, int m3)
        {
            CalculateTotalMarks(m1,m2,m3);
            Console.WriteLine();
            return m1 + m2 + m3;

        }
           
        public static double CalculateAverage(int total, int subjects)
        {
            return total / subjects;
        }

        // Function to get grade
        public static string GetGrade(double avg)
        {
            if (avg >= 90)
                return "A+";
            else if (avg >= 75)
                return "A";
            else if (avg >= 60)
                return "B";
            else if (avg >= 50)
                return "C";
            else
                return "Fail";

        }

        // Function to print full result
        public static void PrintResult(string name, int m1, int m2, int m3, int total, double avg, string grade)
        {
            Console.WriteLine("\n----- STUDENT RESULT -----");
            Console.WriteLine("Name     : " + name);
            Console.WriteLine("Marks 1  : " + m1);
            Console.WriteLine("Marks 2  : " + m2);
            Console.WriteLine("Marks 3  : " + m3);
            Console.WriteLine("Total    : " + total);
            Console.WriteLine("Average  : " + avg);
            Console.WriteLine("Grade    : " + grade);
        }

    }
}
