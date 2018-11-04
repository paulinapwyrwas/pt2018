using System;
namespace LibaryProject.Data
{
    public class Book
    {
        public string title { get; set; }
        public string autor { get; set; }
        public int bookID { get; set; }
        public Boolean isAvailable { get; set; }
        public int readerID { get; set;  }
    }
}
