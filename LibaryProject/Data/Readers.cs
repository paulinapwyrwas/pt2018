using System;
using System.Collections.Generic;

namespace LibaryProject
{
    public class Readers
    {
        private List<Reader> _readersList;

        public Readers()
        {
            _readersList = new List<Reader>();
        }

        public Reader getReader (int index)
        {
            return _readersList[index];
        }

        public void addReader(Reader newReader)
        {
            _readersList.Add(newReader);
        }

    }
}
