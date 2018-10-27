using System;
using System.Collections.Generic;
using LibaryProject.Data;

namespace LibaryProject
{
    public class Borrowing
    {
        private Borrowing(Books b, int ID)
        {
            if (b.ContainsKey(ID))
            {
                if (b[ID].AvailableStatus == true)
                {
                    b[ID].AvailableStatus = false;
                }
                else
                {
                    Console.WriteLine("The book is already borrowed.");
                }
            }

        }
    }
}

    
