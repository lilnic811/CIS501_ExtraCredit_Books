using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LibraryBooks
{
    internal class Controller
    {
        private CloudM _cloud;
        private BindingList<Book> list;
        private LibraryView _view;
        public Controller(LibraryView view,CloudM cloud, LibraryPushToCloud libpushcloud)
        {
            _cloud = cloud;
            libpushcloud = Sync;
        }


        public void Sync(BindingList<Book> list)
        {
            _view.SyncWithCloud();
        }

        public Book GetBook()
        {

        }

        //public Book nextPage(Book book)

        //public Book prevPage(Book book)

        //public Book addBookMark(Book book)

        //public Book removeBook(Book book)

        //public void CloseBook(List<Book> books)
        //update lib with cloud content
        public void SyncWithCloud()
        {
            using (StreamWriter write = new StreamWriter("..\\..\\LibSync.txt"))
            {
                StringBuilder bookInfo = new StringBuilder();
                foreach (Book book in bookList)
                {
                    string tit = book.Title;

                }

            }
        }


    }
}
