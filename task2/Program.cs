using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program {
        static void Main(string[] args) {
            Book book = new Book(new Author("Arthur Conan Doyle", ConsoleColor.Green),
            new Title("Sherlock Holmes", ConsoleColor.Red),
            new Content("Detective", ConsoleColor.Blue));
            book.Show();
            Console.ReadLine();
        
        }
    }
}