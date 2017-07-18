using System.Collections.Generic;

namespace LamdaExpression
{
    public class BookRepository
    {
        public static List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Book1", Price = 5},
                new Book() {Title = "Book2", Price = 7},
                new Book() {Title = "Book3", Price = 17}
            };
        }
    }
}