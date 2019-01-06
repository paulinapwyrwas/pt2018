using System;
namespace LibraryProject.Data
{
    public struct Event
    {
        public Boolean isAvailable;
        public DateTime time;
        public int bookID;

        public Event (Boolean isAvailable, DateTime time, int bookID)
        {
            this.isAvailable = isAvailable;
            this.time = time;
            this.bookID = bookID;
        }
    }
}
