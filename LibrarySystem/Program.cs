using System;
using LibrarySystem;

namespace Main // Note: actual namespace depends on the project name.
{

    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("hello", "hi", "hej");

            Library library = new();

            library.AddBook(book1);
            Console.WriteLine(library.ToString());
        }
    }
}