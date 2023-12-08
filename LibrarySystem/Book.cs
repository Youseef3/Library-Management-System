namespace LibrarySystem
{
    using System;
    public class Book
    {
        // Some properties
        public string ISBN { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public bool CheckedOut { get; set; }

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
        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}";
        }



    }
}
