using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LibaryProject.Data;
using LibaryProject;
using static LibaryProject.BookLogic;

namespace LibaryProject
{
    /*[TestClass]
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
        //http://hamidmosalla.com/2017/02/25/xunit-theory-working-with-inlinedata-memberdata-classdata/
        [Theory]
        [MemberData(nameof(TestDataGenerator.GetBookFromDataGenerator)), MemberType = typeof(TestDataGenerator))]
        public void Test_Book_Borrowing(Book a, Book b)
        {
            Assert.IsTrue(BookLogic.Borrowing(a, a.BookID, a.ReaderID));
            Assert.IsTrue(BookLogic.Borrowing(b, b.BookID, b.ReaderID));
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetBookFromDataGenerator)), MemberType = typeof(TestDataGenerator))]
        public void Test_Book_Returning(Book a, Book b)
        {
            Assert.IsTrue(BookLogic.Borrowing(a, a.BookID, a.ReaderID));
            Assert.IsTrue(BookLogic.Borrowing(b, b.BookID, b.ReaderID));
        }
    }*/

        [TestClass]
        public class BorrowTest
        {
        private Books books;
        private Readers readers;

            //BookLogic logic;
            private Book book;
            private Reader reader;

       
        public BorrowTest()
            {
                // uroczyscie obiecuje ze knuje cos niedobrego
                books = new Books();
                readers = new Readers();


                // koniec psot


                book = new Book(125432, "Harry Potter", "J.K. Rowling"); // <3 
                reader = new Reader("John Smith", 10);
                books.AddBook(book);
                readers.AddReader(reader);
            }

            [TestMethod]

            public void RentAvailableBook()
            {
                Borrowing(books, book.bookID, reader.ID);
                Assert.IsFalse(book.isAvailable);
            }

            [TestMethod]

            public void ReturnBook()
            {
              //  Borrowing(books, book.bookID, reader.ID);
                Returning(books, book.bookID, reader.ID);
                Assert.IsTrue(book.isAvailable);
            }

    }
    }

