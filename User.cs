using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem

{
    public class User : IUser
    {
        public string  Name { get; private set; }
        private List<Book> BorrowedBooks { get; } = new List<Book>();

        public User(string name)
        {
            Name = name;
        }

        public void BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                book.Borrow();
                BorrowedBooks.Add(book);
                Console.WriteLine($"{Name} borrowed '{book.Title}'");
            }
            else
            {
                Console.WriteLine($"'{book.Title}' is not available.");
            }
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                book.Return();
                BorrowedBooks.Remove(book);
                Console.WriteLine($"{Name} returned '{book.Title}'");
            }
            else
            {
                Console.WriteLine($"'{book.Title}' is not borrowed by {Name}.");
            }
        }
    }
}