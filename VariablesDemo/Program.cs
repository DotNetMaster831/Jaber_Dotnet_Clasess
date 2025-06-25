using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Varaibles naming rules

            //1. Start with a letter or underscore
            //int _num = 25;
            //int num = 25;
            //int 5num = 25; //not possible

            ////2. Only letters, digits, and underscores allowed
            //int num1 = 25;
            //int num_1 = 25;
            //int num#1 = 25;

            //3. Dont use keywords
            int hh = 25;

            //4. case senstive
            int age = 25;
            int Age = 25;


            //Varaible declartion rules
            int a = 25;
            int b = 25;
            string name = "jhsdgf";

            int jhsdfghsdfg = 25;


            //Constant
            //Readonly

            //pie value = 3.141

            const float pie = 3.141f;
            //pie = 565;


            //Type Casting or type conversion
            //Converting one data type to other data type.

            //Compile time conversions
            //1.Implicit
            //2. explicit

            //1. Implicit --> copying smaller data to bigger data
            int num = 100;
            double d = num;
            Console.WriteLine("num" + num.GetType().Name);
            Console.WriteLine("d" + d.GetType().Name);

            //Explicit --> copying bigger data to smaller data
            //double pi = 3.14159;
            //Console.WriteLine("before"+pi);
            //int x = (int)pi;
            //Console.WriteLine("after" + x);


            //Run time conversion
            //1. Convert class --> it is responsible to convert one data type to other data type
            //2. Parse --> parse will work with strings. Strings will be converted to other data types.
            //3. TryParse 




            //int pi = Convert.ToInt32(Console.ReadLine()); ;
            //Console.WriteLine("before" + pi);
            //int x = (int)pi;
            //Console.WriteLine("after" + x);


            //float ff = 52.56f;
            //decimal dc = Convert.ToDecimal(true);

            //double hh = double.Parse(Console.ReadLine());
            //int hh1 = int.Parse(Console.ReadLine());
            //float hh2 = float.Parse(Console.ReadLine());

            int gggg = 25;
            //string str1 = "dotnet";

            //gggg = (int)str1;

            bool status = float.TryParse(Console.ReadLine(), out float dd);

        }
    }
}
