using Microsoft.VisualStudio.TestTools.UnitTesting;
/*
using LibaryProject;
using Xunit;

namespace LibraryProject
{
    [TestClass]
    public class UnitTest1
    {
        public class TestDataGenerator : IEnumerable<object[]>
        {
            public static IEnumerable<object[]> GetBookFromDataGenerator()
            {
                yield return new object[]
                {
                    new Book { title = "title1", author = "author1", BookID = 1234, isAvailable = true, readerID = 4567 },
                    new Book { title = "title2", author = "author2", BookID = 8910, isAvailable = false, readerID = 1112 }
                };
            }

        }

        [TestMethod]
        [MemberData(nameof(TestDataGenerator.GetBookFromDataGenerator)), MemberType(typeof(TestDataGenerator))]
        public void Test_Book_Borrowing(Book a, Book b)
        {
            Assert.IsTrue(BookLogic.Borrowing(a, a.BookID, a.ReaderID));
        }
    }
}
*/