using System;
using System.Security.Authentication.ExtendedProtection;
using CleanCodeWorkshops.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CleanCodeWorkshops
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IBooksService, BooksService>()
                .BuildServiceProvider();

            var bookService = serviceProvider.GetService<IBooksService>();

            bookService.BorrowBook("Dziady");
            bookService.ListAuthors();


            Console.ReadLine();
        }
    }
}
