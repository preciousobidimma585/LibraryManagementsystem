﻿using System;
using LibraryManagementSystem;

class Program
{
    static void Main()
    {
        Library library = new Library();


        library.AddBook(new Book("Think Big", "Dr Ben Carson"));
        library.AddBook(new Book("Things fall Apart", "Chinua Achebe"));
        library.AddBook(new Book("Gifted Hands ", "Dr Ben Carson"));


        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        User user = new User(userName);

        try
        {
        start:
            Console.WriteLine("Library Menu:");
            Console.WriteLine("1. View Available Books");
            Console.WriteLine("2. Borrow a Book");
            Console.WriteLine("3. Return a Book");
            Console.WriteLine("4. Exit");
        begin:
            Console.Write("Choose an option: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    library.DisplayAvailableBooks();
                    break;

                case 2:
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

                case 3:
                    Console.Write("Enter book title to return: ");
                    string returnTitle = Console.ReadLine();
                    Book bookToReturn = library.GetBook(returnTitle);

                    if (bookToReturn != null)
                    {
                        user.ReturnBook(bookToReturn);
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Exiting... Thank you for using the Library Management System!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 4.");
                    break;
                    goto begin;

            }
            Console.WriteLine("Do you want to borrow again?:\nEnter yes or no");
            string Choice = Console.ReadLine().ToUpper();
            switch (Choice.ToUpper())
            {
                case "YES":
                    goto start;

                case "NO":
                    Console.WriteLine("Thank you!! do have a nice day");
                    break;

            }
            Console.ReadKey();
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
