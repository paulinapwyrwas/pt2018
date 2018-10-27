using System;
using System.Collections.Generic;

namespace LibaryProject.Data
{
    public class Books : Dictionary<int, Book>
    {
             Dictionary<int, Book> BooksList;

       
            public void set(int ID, Book book)
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

            public int get(int ID)
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
