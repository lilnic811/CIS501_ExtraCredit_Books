
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibraryBooks
{
    internal class LibraryView
    {
        //book list
        List<Book> bookList;

        //get lib from controller

        //method for sync
        //update lib with cloud content
        public void SyncWithCloud()
        {
            using (StreamWriter write = new StreamWriter("..\\..\\LibSync.txt"))
            {
                StringBuilder bookInfo= new StringBuilder();
                foreach (Book book in bookList)
                {
                    string tit = book.Title;
                    
                }

            }
        }
         

        //select/open book (on last open/curr pg)

    }
}
