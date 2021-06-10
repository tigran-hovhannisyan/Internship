using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    public class Reader
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string CardNumber { get; set; }
        public string Phone { get; set; }

        public void TakeBook(int count)
        {
            Console.WriteLine($"{FName} {LName} took {count} book(s)");
        }
        public void TakeBook(Book book)
        {
            Console.WriteLine($"{FName} {LName} took {book.Author}'s \"{book.Name}\" book");
        }
    }
}
