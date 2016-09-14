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

            this.ListView.ItemClick += ListView_ItemClick;
            bookList = new List<Book>();

            bookList.Add(new Book()
            {
                name = "Harry Potter and the Sorcerer's Stone",
                author = "J.K Rowling",
                publisher = "Bloomsbury",
                year = 1997,
                imageId = Resource.Drawable.sorc_stone
            });

            bookList.Add(new Book()
            {
                name = "Harry Potter and the Chamber of Secrets",
                author = "J.K Rowling",
                publisher = "Bloomsbury",
                year = 1998,
                imageId = Resource.Drawable.chamber_secrets
            });

            bookList.Add(new Book()
            {
                name = "Harry Potter and the Prisoner of Azkaban",
                author = "J.K Rowling",
                publisher = "Bloomsbury",
                year = 1999,
                imageId = Resource.Drawable.prisoner_azkaban
            });

            var listAdapter = new BooksAdapter(this);
            listAdapter.books = bookList;
            ListAdapter = listAdapter;
        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            if (e != null)
            {
                var selectedBook = bookList[e.Position];
                var intent = new Android.Content.Intent(this, typeof(BookDetailsActivity));

                Bundle bundle = new Bundle();
                bundle.PutString("selected_book", selectedBook.name);
                bundle.PutInt("selected_image_id", selectedBook.imageId);

                intent.PutExtras(bundle);

                StartActivity(intent);
            }
            else
            {
                return;
            }
        }
    }

    public class Book
    {
        public long id;
        public string name;
        public string author;
        public string publisher;
        public int year;
        public int imageId;

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", this.name, this.author, this.publisher, this.year);
        }
    }
}

