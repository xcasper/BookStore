using Foundation;
using System;
using UIKit;

namespace BookStore
{
    public partial class BookTableViewCell : UITableViewCell
    {
        private Book bookData;
        public Book BookData
        {
            get { return bookData; }
            set
            {
                bookData = value;

                bookNameLabel.Text = bookData.name;
                bookAuthorLabel.Text = bookData.author;
                bookYearLabel.Text = bookData.year.ToString();
                bookPublisherLabel.Text = bookData.publisher;

            }
        }
        public BookTableViewCell (IntPtr handle) : base (handle)
        {
        }
    }
}