// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BookStore
{
    [Register ("BookDetailsViewController")]
    partial class BookDetailsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView bookImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView bookImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bookNameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (bookImage != null) {
                bookImage.Dispose ();
                bookImage = null;
            }

            if (bookImageView != null) {
                bookImageView.Dispose ();
                bookImageView = null;
            }

            if (bookNameLabel != null) {
                bookNameLabel.Dispose ();
                bookNameLabel = null;
            }
        }
    }
}