using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.Mobile.Models
{
    class Student : Person
    {
        public Student()
        {
            this.Address = new Address("", "", "");
            this.Grades = new Dictionary<string, int>();
        }

        public IDictionary<string, int> Grades { get; set; }
    }
}
