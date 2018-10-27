using System;
namespace LibaryProject
{
    public class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public bool AvailableStatus
        {
            get
            {
                return AvailableStatus;
            }
            set => AvailableStatus = true;
        }

        public static implicit operator int(Book v)
        {
            throw new NotImplementedException();
        }
    }
}
