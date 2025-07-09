using System;

namespace OopsDemo
{
    class Person
    {
        //Properties
        public string Name;
        public int Age;
        public string Gender;

        //Behaviours
        public void GetPersonDetails()
        {
            Console.WriteLine("Person Details");
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Gender);
        }
    }
}