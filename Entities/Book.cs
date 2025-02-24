using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem;
 internal class Book : IBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; } = true;

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void Borrow()
    {
        if (IsAvailable)
            IsAvailable = false;
    }

    public void Return()
    {
        IsAvailable = true;
    }
}


    