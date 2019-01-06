using System;
namespace LibraryProject
{
    public class Reader
    {
        public string Name { get; set; }
        public int ID;

        public Reader(string Name, int ID)
        {
            this.Name = Name;
            this.ID =ID;
        }
    }
}
