using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal interface IUser
    {
        string Name {get;}
        void BorrowBook(Book book);
        void ReturnBook(Book book);
        void ViewBorrowedBooks();
    }
}