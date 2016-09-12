using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace BookStore_Android
{
    [Activity(Label = "BookStore_Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        List<Book> bookList;
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            bookList = new List<Book>();

            bookList.Add(new Book()
            {
                name = "Harry Potter and the Sorcerer's Stone",
                author = "J.K Rowling",
                publisher = "Bloomsbury",
                year = 1997
            });

            bookList.Add(new Book()
            {
                name = "Harry Potter and the Chamber of Secrets",
                author = "J.K Rowling",
                publisher = "Bloomsbury",
                year = 1998
            });

            bookList.Add(new Book()
            {
                name = "Harry Potter and the Prisoner of Azkaban",
                author = "J.K Rowling",
                publisher = "Bloomsbury",
                year = 1999
            });

            var listAdapter = new BooksAdapter(this);
            listAdapter.books = bookList;
            ListAdapter = listAdapter;
        }
    }

    public class Book
    {
        public long id;
        public string name;
        public string author;
        public string publisher;
        public int year;

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", this.name, this.author, this.publisher, this.year);
        }
    }
}

