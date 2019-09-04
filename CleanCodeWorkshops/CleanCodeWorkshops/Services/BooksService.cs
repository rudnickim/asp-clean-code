using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CleanCodeWorkshops.Data;
using CleanCodeWorkshops.Models;

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

        public void ListAuthors()
        {
            var books = BooksRepository.GetBooks();

            var authors = new List<Author>();

            foreach (var book in books)
            {
                var bookAuthor = authors.FirstOrDefault(a => a.Name.Equals(book.Author));

                if (bookAuthor == null)
                {
                    bookAuthor = new Author();
                    bookAuthor.Name = book.Author;
                    bookAuthor.Books = new List<Book>();

                    authors.Add(bookAuthor);
                }

                bookAuthor.Books.Add(book);
            }

            foreach (var author in authors)
            {
                Console.WriteLine("---Authors---");
                Console.WriteLine("Name: " + author.Name);
                Console.WriteLine("Author's Books:");
                foreach (var book in author.Books)
                {
                    Console.WriteLine("Title: " + book.Title);
                }
                Console.WriteLine();
            }
        }
    }
}
