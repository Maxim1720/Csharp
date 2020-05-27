using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_2
{
    class Kit
    {
        Book[] BookKit;
        int BooksAmount = 0;
        public void PutBook(Book book)
        {
            BooksAmount++;
            Array.Resize(ref BookKit,BooksAmount);
            BookKit[BooksAmount - 1] = book;
        }
        public Book[] GetKit()
        {
            return BookKit;
        }
    }
}
