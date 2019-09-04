using System;
using CleanCodeWorkshops.ComplexMethod;

namespace CleanCodeWorkshops
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookService = new BooksService();

            bookService.BorrowBook("Dziady");
            bookService.ListAuthors();


            Console.ReadLine();
        }
    }
}
