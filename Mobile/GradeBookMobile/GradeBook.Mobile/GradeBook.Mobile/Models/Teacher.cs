using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.Mobile.Models
{
    public class Teacher : Person
    {
        public Teacher()
        {
            this.Address = new Address("", "", "");
        }

        public Teacher(string firstName, string lastName, string email, string city, string zipCode, string street, int age, string schoolName)
            : base(firstName, lastName, email, city, zipCode, street, age)
        {
            this.SchoolName = schoolName;
        }

        public string SchoolName { get; set; }


        public override string ToString()
        {
            return "Email: " + this.Email + "\n Name: " + this.FirstName;
        }
    }
}
