using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public interface IBook
    {
        string Title {get; set;}
        string Author {get; set;}
        bool IsAvailable {get; set;}

        void Borrow();
        void Return();
        
    }
}