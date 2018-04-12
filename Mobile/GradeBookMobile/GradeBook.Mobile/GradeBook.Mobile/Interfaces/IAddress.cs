using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.Mobile.Interfaces
{
    public interface IAddress
    {
        string City { get; set; }

        string ZipCode { get; set; }

        string Street { get; set; }
    }
}
