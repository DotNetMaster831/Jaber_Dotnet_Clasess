using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Data Types
            //Varaible --> it is a name given to the data 

            /*
             * "Imagine you run a supermarket. You store different kinds of data:

                Name of product (string)

                Quantity (int)

                Price (float/double/decimal)

                Is it available? (bool)


                1. Value type Data type --> which stores value directly in memory
                2. Pointer Data Type --> stores address of the variable
                3. Refrence data type --> the data type stores refrence of varaible 

                1.Type of Value type data type
                    Predefined Data Types – Example includes Integer, Boolean, Long, Double, Float, etc.
`                   User-defined Data Types – Example includes Structure, Enumerations, etc.


             * 
             */

            ////Integers
            //byte a = 1; //8 bit storage --> 0 to 255
            //sbyte b = -2; // 8 bit --> -128 to 127 (signed byte)

            //short c = 3; // 16 bit --> -32768 to 32768

            //ushort d = 4; // 16 bit --> 0 to 65535(unsigned)

            //int e = 5; //32 bit --> -2,147,483,648 to 2,147,483,647

            //uint f = 6; //32 bit --> 0 to 4,294,967,295

            //float i = 9; //32 bit --> ±1.5 × 10⁻⁴⁵ to ±3.4 × 10³⁸

            //long g = 7; //64 bit --> -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

            //ulong h = 8;//64 bit --> 0 to 18,446,744,073,709,551,615

            //double j = 10; //64 bit --> 	±5.0 × 10⁻³²⁴ to ±1.7 × 10³⁰⁸

            //decimal k = 11; //128 bit --> 28-29 digts(1.22222222222222222222222222222222222222)


            ////Data 
            //char l = 'd';

            //string m = "ddkkkl";


            //Example
            //Super Market Billing System
            string productName = "Milk Packet";
            byte productCode = 101;
            short stockAvailable = 500;
            int supplierId = 123456;
            long inventoryId = 9876534210;

            //decimal
            float weight = 1.5f;
            double mrp = 32.56;
            decimal sellingPrice = 29.56m;

            bool isAvialable = true;

            //string
            string gg = "Dotnet";
            gg = "hi dotnet";
            //$ {}

            // Display Product Details
            Console.WriteLine("---------- Supermarket Billing ----------");
            Console.WriteLine($"Product: {productName} (Code: {productCode})");
            Console.WriteLine($"Supplier ID: {supplierId}");
            Console.WriteLine($"Inventory ID: {inventoryId}");
            Console.WriteLine($"Stock Available: {stockAvailable}");
            Console.WriteLine($"Weight: {weight} Kg");
            Console.WriteLine($"MRP: {mrp} INR");
            Console.WriteLine($"Selling Price: {sellingPrice} INR");
            Console.WriteLine($"Available: {isAvialable}");

            //Console.WriteLine($"Product:" + productName + "(Code: " + productCode);
            //Console.WriteLine($"Product: {productName} (Code: {productCode})");

            //int aa = 25;

            //Console.WriteLine("Hi, my age is :" + aa);
            //Console.WriteLine($"Hi, my age is :  {aa}");


            //Refrence data types
            //1. pre defined --> object, string
            //2. user defined --> class

            //Heap



            Console.ReadKey();
        }
    }
}
