using System;

namespace OopsDemo
{
    class Book
    {
        public string Title;
        public string Author;
        public double Price;
        public string ISBN;

        public void PrintBookInfo()
        {
            Console.WriteLine("Book Information");
            Console.WriteLine($"Title of the book is :{Title}");
            Console.WriteLine($"Author of the book is :{Author}");
            Console.WriteLine($"Price of the book is :{Price}");
            Console.WriteLine($"ISBN of the book is :{ISBN}");
        }
    }
}