using System;
using LibraryManagementSystem;
using System;
using LibraryManagementSystem.Models;

class Program
{
    static void Main()
    {
        Library library = new Library();

        
        library.AddBook(new Book("Things Fall Apart", "Chinua Achebe"));
        library.AddBook(new Book("Think Big ", "Dr Ben Carson"));
        library.AddBook(new Book("7 books of moses", "Precious Obidimma"));


        while (true)
        {
            try
            {
                Console.WriteLine("\n📚 Library System:");
                Console.WriteLine("1. Register User");
                Console.WriteLine("2. View Users");
                Console.WriteLine("3. View Available Books");
                Console.WriteLine("4. Borrow a Book");
                Console.WriteLine("5. Return a Book");
                Console.WriteLine("6. View Borrowed Books");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter user name to register: ");
                        string newUser = Console.ReadLine();
                        library.RegisterUser(newUser);
                        break;

                    case 2:
                        library.DisplayUsers();
                        break;

                    case 3:
                        library.DisplayAvailableBooks();
                        break;

                    case 4:
                        Console.Write("Enter your name: ");
                        string borrowUser = Console.ReadLine();
                        User user = library.GetUser(borrowUser);

                        if (user == null)
                        {
                            Console.WriteLine("User not found! Please register first.");
                            break;
                        }

                        Console.Write("Enter book title to borrow: ");
                        string borrowTitle = Console.ReadLine();
                        Book bookToBorrow = library.GetBook(borrowTitle);

                        if (bookToBorrow != null)
                        {
                            user.BorrowBook(bookToBorrow);
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;

                    case 5:
                        Console.Write("Enter your name: ");
                        string returnUser = Console.ReadLine();
                        User userToReturn = library.GetUser(returnUser);

                        if (userToReturn == null)
                        {
                            Console.WriteLine("User not found! Please register first.");
                            break;
                        }

                        Console.Write("Enter book title to return: ");
                        string returnTitle = Console.ReadLine();
                        Book bookToReturn = library.GetBook(returnTitle);

                        if (bookToReturn != null)
                        {
                            userToReturn.ReturnBook(bookToReturn);
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;

                    case 6:
                        Console.Write("Enter your name: ");
                        string viewUser = Console.ReadLine();
                        User userToView = library.GetUser(viewUser);

                        if (userToView != null)
                        {
                            userToView.ViewBorrowedBooks();
                        }
                        else
                        {
                            Console.WriteLine("User not found! Please register first.");
                        }
                        break;

                    case 7:
                        Console.WriteLine("Exiting... Thank you for using the Library Management System!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please enter a number between 1 and 7.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
