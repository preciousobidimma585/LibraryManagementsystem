using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem

{
    public class Library
    {
        private List<Book> Books { get; } = new List<Book>();
        private List<User> Users { get; } = new List<User>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RegisterUser(string userName)
        {
            if (!Users.Any(u => u.Name.Equals(userName, StringComparison.OrdinalIgnoreCase)))
            {
                Users.Add(new User(userName));
                Console.WriteLine($"User '{userName}' registered successfully.");
            }
        }

        public User GetUser(string userName)
        {
            return Users.FirstOrDefault(u => u.Name.Equals(userName, StringComparison.OrdinalIgnoreCase));
        }

        public Book GetBook(string title)
        {
            return Books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        public void DisplayAvailableBooks()
        {
            var availableBooks = Books.Where(b => b.IsAvailable).ToList();
            if (availableBooks.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            Console.WriteLine("Available Books:");
            foreach (var book in availableBooks)
            {
                Console.WriteLine($"- {book.Title} by {book.Author}");
            }
        }

        public void DisplayUsers()
        {
            if (Users.Count == 0)
            {
                Console.WriteLine("No registered users.");
                return;
            }

            Console.WriteLine("Registered Users:");
            foreach (var user in Users)
            {
                Console.WriteLine($"- {user.Name}");
            }
        }
    }
}





    