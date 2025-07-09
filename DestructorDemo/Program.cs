using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee();
            //Employee emp2 = new Employee();
            //Employee emp3 = new Employee();
            //Employee emp4 = new Employee();
            //Employee emp5 = new Employee();
            //Employee emp6 = new Employee();
            //Employee emp7 = new Employee();
            //Employee emp8 = new Employee();
            //Employee emp9 = new Employee();
            //Employee emp10 = new Employee();
            //Employee emp11 = new Employee();
            //Employee emp12 = new Employee();
            //Employee emp13 = new Employee();
            //Employee emp14 = new Employee();
            //Employee emp15 = new Employee();

            //emp1.Greet();
            //emp2.Greet();
            //emp3.Greet();
            //emp4.Greet();
            //emp5.Greet();

            //Grabage collector

            for(int i = 0; i <= 1000000; i++)
            {
                MyClass1 myClass1 = new MyClass1();
                MyClass2 myClass2 = new MyClass2();
                MyClass3 myClass3 = new MyClass3();
            }

        }
    }


    public class Employee
    {

        public Employee()
        {

        }

        ~Employee()
        {

        }


        public void Greet()
        {
            Console.WriteLine("Hello");
        }
    }


    public class MyClass1
    {
        ~MyClass1()
        {

        }
    }

    public class MyClass2
    {
        ~MyClass2()
        {

        }
    }

    public class MyClass3
    {
        ~MyClass3()
        {

        }
    }

    public class CleanObjects : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
