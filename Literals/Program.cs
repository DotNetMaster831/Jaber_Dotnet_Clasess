using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literals
{
    internal class Program
    {

        const float piValue = 3.141f;
        readonly float piValue2;
        public static int AA = 25;

        public Program()
        {
            piValue2 = 31.45f;
        }

        static void Main(string[] args)
        {
            aa
            
            float vv  = 2 * aInGetMessage;
            aInGetMessage

            //Literals
            //int age = 25;
            //A literal is hardcoded constant value written directly into the code
            //Types
            //1. Integre
            //2. floating point
            //3. character 
            //4. string
            //5. boolean
            //6. null

            string name = "Dotnet";

            //Operators
            //1. Arithmetic --> +,-,*,/,%
            //2. Comparsion --> ==, >, >=,<,<=, !=
            //3. Logical --> --> &&, ||, !
            //4. Assignement --> =, +=, -=, *=,/=
            //5. Unary --> ++, --
            //6. Ternary --> ? :

            //AND(&&)
            //T , T = T
            //T , F = F
            //F , T = F
            //F , F = F

            //OR(||)
            //T , T = T
            //T , F = T
            //F , T = T
            //F , F = F

            //NOT(!)
            //T  = F
            //F = T

            //Arithmetic Operators
            int a = 10;
            int b = 20;

            Console.WriteLine(a + b); // 13
            Console.WriteLine(a - b); // 7
            Console.WriteLine(a * b); // 30
            Console.WriteLine(a / b); // 3
            Console.WriteLine(a % b); // 1 (modulus = remainder)

            //Comparison
            Console.WriteLine("Comparison");
            int age = 18;

            Console.WriteLine(age >= 18);
            Console.WriteLine(age == 18);
            Console.WriteLine(age != 18);
            Console.WriteLine(age <= 18);

            //Logical
            Console.WriteLine("Logical");

            bool isStudent = false;
            bool hasIdCard = true;
            Console.WriteLine(isStudent && hasIdCard);
            Console.WriteLine(isStudent || hasIdCard);
            Console.WriteLine(!isStudent);


            Console.WriteLine("Assignement");

            int num1 = 25;
            Console.WriteLine(num1);
            //num1 *= 25;
            //Console.WriteLine(num1);
            num1++;
            Console.WriteLine(num1);

            //readonly
            //constant

            

            
            

            Console.ReadKey();
        }

        public void GetMessage()
        {
            int aInGetMessage = 10;
        }
    }
}
