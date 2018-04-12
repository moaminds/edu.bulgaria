using GradeBook.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.Mobile.Interfaces
{
    public interface IPerson
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string FullName { get; set; }

        string Email { get; set; }

        IAddress Address { get; set; }

        int Age { get; set; }
    }
}
