using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWorkshops.Models
{
    public class Book
    {
        private bool isBorrowed;
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public bool IsBorrowed
        {
            get => isBorrowed;
            set
            {
                isBorrowed = value;
                BorrowedCount++;
            }
        }

        public int BorrowedCount { get; set; }
    }
}
