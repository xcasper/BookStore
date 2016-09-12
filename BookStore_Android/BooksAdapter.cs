using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace BookStore_Android
{
    public class BooksAdapter : BaseAdapter
    {
        public List<Book> books;
        Activity activity;
        public BooksAdapter(Activity activity)
        {
            books = new List<Book>();
            this.activity = activity;
        }

        public override int Count
        {
            get
            {
                return books.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return books[position].id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.BookCell, parent, false);

            var nameTextView = view.FindViewById<TextView>(Resource.Id.bookNameTextView);
            var authorTextView = view.FindViewById<TextView>(Resource.Id.bookAuthorTextView);
            var yearTextView = view.FindViewById<TextView>(Resource.Id.bookYearTextView);
            var publisherTextView = view.FindViewById<TextView>(Resource.Id.bookPublisherTextView);

            var data = books[position];

            nameTextView.Text = data.name;
            authorTextView.Text = data.author;
            yearTextView.Text = data.year.ToString();
            publisherTextView.Text = data.publisher;

            return view;
        }
    }
}