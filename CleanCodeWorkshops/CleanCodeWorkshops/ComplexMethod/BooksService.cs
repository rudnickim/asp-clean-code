using System;
using System.Collections.Generic;
using System.Text;
using CleanCodeWorkshops.Data;

namespace CleanCodeWorkshops.ComplexMethod
{
    public class BooksService
    {
        public void BorrowBook(string title)
        {
            var books = BooksRepository.GetBooks();

            Console.WriteLine("----Books Available:----");
            Console.WriteLine("");
            foreach (var book in books)
            {
                if (book.IsBorrowed)
                {
                    continue;
                }

                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Is borrowed: " + book.IsBorrowed);
                Console.WriteLine("");
            }

            foreach (var book in books)
            {
                if (book.Title.Contains(title))
                {
                    if (book.IsBorrowed)
                    {
                        Console.WriteLine("Book already borrowed!");
                        Console.WriteLine("");
                    }

                    book.IsBorrowed = true;
                    Console.WriteLine("Book was borrowed:");
                    Console.WriteLine("Title: " + book.Title);
                    Console.WriteLine("Author: " + book.Author);
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("----Books Available:----");
            Console.WriteLine("");
            foreach (var book in books)
            {
                if (book.IsBorrowed)
                {
                    continue;
                }

                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Is borrowed: " + book.IsBorrowed);
                Console.WriteLine("");
            }
        }
    }
}
