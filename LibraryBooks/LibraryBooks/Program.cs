using System;
using System.ComponentModel;

namespace LibraryBooks
{
    public delegate void BookViewDel(int index);

    public delegate void LibraryPushToCloud(BindingList<Book> bookList);
    internal class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LibraryView libraryView = new LibraryView();
            BookView bookView = new BookView();
            //when lib select book call open on curr page
            BookViewDel bookDelegate = new BookViewDel(bookView.GoToPage);
            bookView.GoToPage(0);
        }
    }
}
