using System;
using System.Collections.Generic;

namespace LibaryProject.Data
{
    public class Books : Dictionary<int, Book>
    {
        Dictionary<int, Book> BooksList;


        public void Set(int ID, Book book)
        {
            if (BooksList.ContainsKey(ID))
            {
                BooksList[ID] = book;
            }
            else
            {
                BooksList.Add(ID, book);
            }
        }

        public Book Get(int ID)
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
