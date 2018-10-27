using System;
namespace LibaryProject
{
    public class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }

        public static implicit operator int(Book v)
        {
            throw new NotImplementedException();
        }
    }
}
