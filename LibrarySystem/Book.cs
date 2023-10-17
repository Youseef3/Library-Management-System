namespace LibrarySystem
{
    using System;
    public class Book
    {
        // Some properties
        public string ISBN { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public bool CheckedOut { get; private set; }

        public Book(string isbn, string title, string author)
        {
            if (string.IsNullOrWhiteSpace(isbn) || string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                throw new ArgumentException("ISBN, Title and Author cannot be empty!");

            }

            Title = title;
            ISBN = isbn;
            Author = author;
            CheckedOut = false;
        }




        // Function for checking if the book is checked out
        public bool CheckOut()
        {
            if (CheckedOut)
            {
                Console.WriteLine($"Sorry, {Title} is already checked out!");
                return false;
            }
            else
            {
                Console.WriteLine($"{Title} is now checked out!");
                CheckedOut = true;
                return true;
            }

        }

        // Function for returning a book
        public bool ReturnBook()
        {
            if (CheckedOut)
            {
                Console.WriteLine($"You've successfully returned {Title}.");
                CheckedOut = false;
                return true;

            }
            else
            {
                Console.WriteLine($"{Title} cannot be returned as it was never checked out!");
                return false;
            }

        }



    }
}
