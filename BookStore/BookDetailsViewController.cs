using Foundation;
using System;
using UIKit;

namespace BookStore
{
    public partial class BookDetailsViewController : UIViewController
    {
        public Book selectedBook;
        public BookDetailsViewController (IntPtr handle) : base (handle)
        {

        }

        public override void ViewWillAppear(bool animated)
        {
            bookNameLabel.Text = selectedBook.name;
            bookImageView.Image = UIImage.FromFile(selectedBook.imagePath);
        }
    }
}