using System;
using System.Collections.Generic;
namespace LibaryProject.Data
                      
{
    public class History
    {
        List<Event> eventHistory;
        public History()
        {
            eventHistory = new List<Event>();
        }

        public void AddEvent(Book b)
        {
            Event _event = new Event(b.isAvailable, DateTime.Now, b.bookID);
            eventHistory.Add(_event);
        }
    }
}