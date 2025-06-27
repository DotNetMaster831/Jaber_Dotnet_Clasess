using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValueCallByRef
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if(args.Length > 0)
            {
                Console.WriteLine(args[0]);
                Console.WriteLine(args[1]);
            }


            //Call by Value

            int a = 15;
            //int b = a;

            //b = 30;
            UpdateValue(a);

            Console.WriteLine(a);


            //call by ref

            int c = 15;

            UpdateValue(ref c);
            Console.WriteLine(c);





            Console.ReadKey();



        }


        private static void UpdateValue(int b)
        {
            b = 30;
        }

        private static void UpdateValue(ref int b)
        {
            b = 30;
        }
    }


}
