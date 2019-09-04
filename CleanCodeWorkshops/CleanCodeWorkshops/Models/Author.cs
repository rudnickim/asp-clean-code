using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWorkshops.Models
{
    public class Author
    {
        public string Name { get; set; }
        public IList<Book> Books { get; set; }
    }
}
