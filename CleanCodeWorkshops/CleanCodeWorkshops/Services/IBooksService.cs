using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWorkshops.Services
{
    public interface IBooksService
    {
        void BorrowBook(string title);
        void ListAuthors();
    }
}
