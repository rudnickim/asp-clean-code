using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using CleanCodeWorkshops.Models;

namespace CleanCodeWorkshops.Data
{
    public static class BooksRepository
    {
        public static IList<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book
                {
                    Author = "Adam Mickiewicz",
                    Title = "Dziady cz. 3",
                    Id = Guid.NewGuid(),
                    IsBorrowed = false,
                    BorrowedCount = 2
                },
                new Book
                {
                    Author = "Bolesław Prus",
                    Title = "Lalka",
                    Id = Guid.NewGuid(),
                    IsBorrowed = false,
                    BorrowedCount = 5
                },
                new Book
                {
                    Author = "Juliusz Słowacki",
                    Title = "Kordian",
                    Id = Guid.NewGuid(),
                    IsBorrowed = false,
                    BorrowedCount = 16
                },
                new Book
                {
                    Author = "Adam Mickiewicz",
                    Title = "Pan Tadeusz",
                    Id = Guid.NewGuid(),
                    IsBorrowed = false,
                    BorrowedCount = 13
                },
            }.ToList();
        }
    }
}
