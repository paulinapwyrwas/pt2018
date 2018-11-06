using System;
using System.Collections;
namespace LibraryProojectTest
{
    public class DataGenerator
    {
        public DataGenerator()
        {
        }
        public class TestDataGenerator : IEnumerable<object>
        {
            public static IEnumerable<object[]> GetBookFromDataGenerator()
            {
                yield return new object[]
                {
                     new Book { "title1", "author1", 1234, true, 4567 }
                };
            }

        }
    }
}
