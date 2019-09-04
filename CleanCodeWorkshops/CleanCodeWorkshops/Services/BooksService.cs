using System;
using System.Collections.Generic;
using System.Linq;
using CleanCodeWorkshops.Data;
using CleanCodeWorkshops.Models;

namespace CleanCodeWorkshops.Services
{
    public class BooksService : IBooksService
    {
        public void BorrowBook(string title)
        {
            var books = BooksRepository.GetBooks();

            ListAvailableBooks(books);

            books.Where(b => b.Title.Contains(title))
                .ToList()
                .ForEach(BorrowBook);

            ListAvailableBooks(books);
        }

        public void ListAuthors()
        {
            var books = BooksRepository.GetBooks();

            var authors = books.GroupBy(b => b.Author)
                .Select(items => new Author
                {
                    Name = items.Key,
                    Books = items.ToList()
                })
                .ToList();

            ListAuthors(authors);
        }

        private void BorrowBook(Book book)
        {
            if (BookCanBeBorrowed(book))
            {
                book.IsBorrowed = true;
                BookedBorrowedInfo(book);
            }
        }

        private void ListAvailableBooks(IList<Book> books)
        {
            Console.WriteLine("----Books Available:----");
            Console.WriteLine("");
            foreach (var book in books.Where(b => !b.IsBorrowed))
            {
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Is borrowed: " + book.IsBorrowed);
                Console.WriteLine("Burrowed no.: " + book.BorrowedCount);
                Console.WriteLine("");
            }
        }

        private bool BookCanBeBorrowed(Book book)
        {
            if (!book.IsBorrowed) return true;

            Console.WriteLine("Book already borrowed!");
            Console.WriteLine("");
            return false;
        }

        private void BookedBorrowedInfo(Book book)
        {
            Console.WriteLine("Book was borrowed:");
            Console.WriteLine("Title: " + book.Title);
            Console.WriteLine("Author: " + book.Author);
            Console.WriteLine("");
        }

        private void ListAuthors(IList<Author> authors)
        {
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
