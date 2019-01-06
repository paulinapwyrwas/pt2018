using System;
using System.Collections.Generic;

namespace LibraryProject.Data
{
    public class Books : Dictionary<int, Book>
    {
        Dictionary<int, Book> BooksList;

        public Books()
        {
            BooksList = new Dictionary<int, Book>();
        }

        public void AddBook(Book book)
        {
            if (BooksList.ContainsKey(book.bookID))
            {
                BooksList[book.bookID] = book;
            }
            else
            {
                BooksList.Add(book.bookID, book);
            }
        }

        public Book GetBook(int ID)
        {
            try
            {
                if (BooksList.ContainsKey(ID))
                {
                    return BooksList[ID];
                }
                else
                {
                    //throw new Exception("No book with such ID");
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return null;
            }

        }

    }
}
