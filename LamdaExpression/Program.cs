using System;
using System.Collections.Generic;

namespace LamdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = BookRepository.GetBooks();
            var result = books.FindAll(book => book.Price > 10);
            foreach(var item in result)
                Console.WriteLine(item.Title);
            Console.ReadLine();

        }

        public static bool IsCheaperThan10Dollarrs(Book book)
        {
            return book.Price < 10;
        }
    }
}
