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

    public bool RemoveBookByISBN(string isbn)
    {

        if (isbn == null)
        {
            throw new ArgumentNullException("ISBN cannot be null.");
        }

        bool foundISBN = false;
        Book removeBook = collection.Find(book => book.ISBN == isbn);

        if (removeBook != null) // indicating that a book has been removed (eg. it actually found a book)
        {
            collection.Remove(removeBook);
            foundISBN = true;
        }
        return foundISBN;
    }

    public List<Book> SearchByTitle(string title)
    {
        if (title == null)
        {
            throw new ArgumentNullException("Title cannot be null.");
        }

        title = title.ToLower();
        return collection.FindAll(book => book.Title.ToLower() == title); //there can be several books with the same name - therefore using FindAll here

    }
    public List<Book> SearchByAuthor(string author)
    {
        if (author == null)
        {
            throw new ArgumentException("Author cannot be null.");
        }

        author = author.ToLower();
        return collection.FindAll(book => book.Author.ToLower() == author);

    }

    public bool CheckOutByTitle(string title)
    {
        if (title == null)
        {
            throw new ArgumentNullException("Title cannot be null.");
        }
        List<Book> checkBooks = collection.FindAll(book => book.Title == title);

        foreach (Book book in checkBooks)
        {
            if (!book.CheckedOut)
            {
                book.CheckedOut = true;
                Console.WriteLine($"{book.Title} is now checked out!");
                return true;
            }
        }

        Console.WriteLine($"Sorry, we do not have {title} available at the moment!");
        return false;

    }

    // Function for returning a book
    public bool ReturnBookByISBN(string isbn)
    {

        if (isbn == null)
        {
            throw new ArgumentNullException("ISBN cannot be null.");
        }
        Book returnBook = collection.Find(book => book.ISBN == isbn);


        if (returnBook == null)
        {
            Console.WriteLine("No book with this ISBN was found.");
            return false;
        }
        if (returnBook.CheckedOut)
        {
            Console.WriteLine($"You have successfully returned {returnBook.Title}.");
            returnBook.CheckedOut = false;
            return true;

        }
        else
        {
            Console.WriteLine($"The book with ISBN {isbn} cannot be returned as it was never checked out.");
            return false;
        }

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
