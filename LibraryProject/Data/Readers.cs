using System;
using System.Collections.Generic;

namespace LibraryProject
{
    public class Readers
    {
        private List<Reader> _readersList;

        public Readers()
        {
            _readersList = new List<Reader>();
        }

        public Reader GetReader (int index)
        {
            return _readersList[index];
        }

        public void AddReader(Reader newReader)
        {
            _readersList.Add(newReader);
        }

    }
}
