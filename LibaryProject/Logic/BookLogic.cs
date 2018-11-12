using System;
using System.Collections.Generic;
using LibaryProject.Data;

namespace LibaryProject
{
    public static class BookLogic
    {
        public static void Borrowing(Books b, int BookID, int ReaderID)
        {
            Book book = b.GetBook(BookID);
            if (book.isAvailable == true)
            {
                book.isAvailable = false;
                book.readerID = ReaderID;
                History history = new History();
                history.AddEvent(book);
            }
            else
            {
                Console.WriteLine("The book is already borrowed.");
            }


        }
        public static void Returning(Books b, int BookID, int ReaderID)
        {
            if (b.ContainsKey(BookID))
            {
                if (b[BookID].isAvailable == false && b[BookID].readerID == ReaderID)
                {
                    b[BookID].isAvailable = true;
                    b[BookID].readerID = 0;
                }
                else
                {
                    Console.WriteLine("You can't return this book.");
                }
            }

        }
    }
}

    
