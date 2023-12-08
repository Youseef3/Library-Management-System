using System.Collections.Generic;
using LibrarySystem;

public class Library
{
    private List<Book> collection = new();

    public void AddBook(Book book)
    {
        if (book == null)
        {
            throw new ArgumentNullException("Book cannot be null.");
        }

        if (collection.Contains(book))
        {
            throw new InvalidOperationException("This book already exists in the library.");
        }

        collection.Add(book);
    }

    public void RemoveBook(string isbn)
    {

    }

    public void SearchByTitle(string title)
    {

    }

    public void SearchByAuthor(string author)
    {

    }

    public void CheckOutBook(string isbn)
    {

    }

    public void ReturnBook(string isbn)
    {

    }







    public override string ToString()
    {
        string result = "";
        foreach (var book in collection)
        {
            result += book.ToString() + "\n";
        }
        return result;
    }
}
