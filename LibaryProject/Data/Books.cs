using System;
using System.Collections.Generic;

namespace LibaryProject.Data
{
    public class Books
    {
        private Dictionary<int, Book> BooksList = new Dictionary <int, Book>();

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

            public int Get(int ID)
            {
                int result = 0;

                if (BooksList.ContainsKey(ID))
                {
                result = BooksList[ID];
                }

                return result;
            }

    }
}
