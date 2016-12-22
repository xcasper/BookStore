using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace BookStore
{
    public partial class BooksTableViewController : UITableViewController
    {
        List<Book> bookList;
        public BooksTableViewController (IntPtr handle) : base (handle)
        {
            bookList = new List<Book>();

            bookList.Add(new Book()
            {
                name = "Harry Potter and the Sorcerer's Stone",
                author = "J.K Rowling",
                publisher = "Bloomsbury",
                year = 1997,
                imagePath = "Images/sorc_stone.jpg"
            });

            bookList.Add(new Book()
            {
                name = "Harry Potter and the Chamber of Secrets",
                author = "J.K Rowling",
                publisher = "Bloomsbury",
                year = 1998,
                imagePath = "Images/chamber_secrets.jpg"
            });

            bookList.Add(new Book()
            {
                name = "Harry Potter and the Prisoner of Azkaban",
                author = "J.K Rowling",
                publisher = "Bloomsbury",
                year = 1999,
                imagePath = "Images/prisoner_azkaban.jpg"
            });
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return bookList.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("Book") as  BookTableViewCell;
            var data = bookList[indexPath.Row];
            cell.BookData = data;
            return cell;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "bookDetailsSegue")
            {
                var navigationController = segue.DestinationViewController as BookDetailsViewController;

                if(navigationController != null)
                {
                    var rowPath = TableView.IndexPathForSelectedRow;
                    var selectedData = bookList[rowPath.Row];
                    navigationController.selectedBook = selectedData;
                }
            }
        }
    }

    public class Book
    {

        public string name;
        public string author;
        public string publisher;
        public int year;
        public string imagePath;
    }
}