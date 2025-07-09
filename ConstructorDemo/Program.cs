using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test(30, true, "t1 object");
            Console.WriteLine(t1.i);
            Console.WriteLine(t1.b);
            Console.WriteLine(t1.s);
            //t1.i = 30;
            //t1.b = true;
            //t1.s = "t1 object";
            Console.WriteLine(t1.i);
            Console.WriteLine(t1.b);
            Console.WriteLine(t1.s);

            Console.WriteLine();


            //Test t2 = new Test();
            //Console.WriteLine(t2.i);
            //Console.WriteLine(t2.b);
            //Console.WriteLine(t2.s);
            //t2.i = 40;
            //t2.b = false;
            //t2.s = "t2 object";
            //Console.WriteLine(t2.i);
            //Console.WriteLine(t2.b);
            //Console.WriteLine(t2.s);

            //Console.WriteLine();

            //Test t3 = new Test();
            //Console.WriteLine(t3.i);
            //Console.WriteLine(t3.b);
            //Console.WriteLine(t3.s);
            //t3.i = 50;
            //t3.b = true;
            //t3.s = "t3 object";
            //Console.WriteLine(t3.i);
            //Console.WriteLine(t3.b);
            //Console.WriteLine(t3.s);







            //Types
            //1. Default or Parameterless
            //2. Parameterized
            //3. copy 
            //4. static constructor
            //5. private
        }
    }
}
