Classes to Design:

Book:

Attributes:
ISBN: (String) A unique identifier for the book.
title: (String) The title of the book.
author: (String) The author of the book.
checked_out: (Boolean) Whether the book is checked out or not.
Methods:
check_out(): Checks out the book. If already checked out, return a message.
return_book(): Returns the book. If not checked out, return a message.
Library:

Attributes:
collection: (List) A list of Book objects that are in the library.
Methods:
add_book(isbn, title, author): Adds a book to the library collection.
remove_book(isbn): Removes a book from the library collection using its ISBN.
search_by_title(title): Returns a list of books that match the given title.
search_by_author(author): Returns a list of books written by the given author.
check_out_book(isbn): Checks out a book using its ISBN.
return_book(isbn): Returns a book using its ISBN.
User:

Attributes:
name: (String) The name of the user.
borrowed_books: (List) A list of ISBNs representing books the user has currently borrowed.
Methods:
borrow_book(library, isbn): Borrows a book from the library. Adds the ISBN to borrowed_books and checks out the book from the library.
return_book(library, isbn): Returns a borrowed book to the library. Removes the ISBN from borrowed_books and returns the book to the library.
Driver/Main:

A small section of code to demonstrate the functionality of the system. Add a few sample books to the library, create a user, have the user borrow and return a book, etc.