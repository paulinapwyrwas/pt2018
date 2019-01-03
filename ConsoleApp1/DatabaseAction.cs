﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class DatabaseAction
    {
        private Database database;
        public DatabaseAction()
        {
            database = new Database();
        }

        public void insertData<T>(List<T> data)
        {
            if (!database.Books.Any() && data is List<Book>)
            {
                foreach (var book in data.Cast<Book>().ToList())
                {
                    database.Books.Add(book);
                }
            }

            else if (!database.History.Any() && data is List<Event>)
            {
                foreach (var reader in data.Cast<Event>().ToList())
                {
                    database.Readers.Add(reader);
                }
            }
            database.SaveChanges();
        }

        public void insertSingleObject<T>(T obj)
        {

            if (obj is Book)
            {
                databasb.Addresses.Add(Book)(object)obj);
            }
            else if (obj is Event)
            {
                database.Books.Add((Event)(object)obj);
            }
            database.SaveChanges();
        }

        public void deleteRow<T>(T obj)
        {
            if (obj is Book)
            {
                database.Addresses.Remove((Book)(object)obj);
            }
            else if (obj is Event)
            {
                database.Books.Remove((Event)(object)obj);
            }
            database.SaveChanges();
        }

        public List<Book> readBooks()
        {
            var database = new LibraryDatabase();
            var BooksFromDb = new List<Book>();
            if (database.Books.Any())
            {
                var query = from book in database.Books
                            select book;
                foreach (var book in query)
                {
                    BooksFromDb.Add(book);
                }
            }
            return BooksFromDb;
        }
    } }
