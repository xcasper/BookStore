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

namespace BookStore_Android
{
    [Activity(Label = "BookDetailsActivity")]
    public class BookDetailsActivity : Activity
    {
        private TextView bookNameTextView;
        private ImageView bookCoverImageView;
        Book selectedBook;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.SetContentView(Resource.Layout.BookDetails);

            bookNameTextView = FindViewById(Resource.Id.bookNameTextView) as TextView;
            bookCoverImageView = FindViewById(Resource.Id.bookCoverImageView) as ImageView;

            selectedBook = new Book();
            selectedBook.name = Intent.Extras.GetString("selected_book");
            selectedBook.imageId = Intent.Extras.GetInt("selected_image_id");

            bookNameTextView.Text = selectedBook.name;
            bookCoverImageView.SetImageResource(selectedBook.imageId);
        }
    }
}