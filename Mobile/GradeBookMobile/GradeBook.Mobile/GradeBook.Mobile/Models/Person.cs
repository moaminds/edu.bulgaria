using GradeBook.Mobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.Mobile.Models
{
    public class Person : IPerson
    {
        private string fullName;

        public Person() { }

        public Person(string firstName, string lastName, string email, string city, string zipCode, string street, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Address = new Address(city,zipCode,street);
            this.Age = age;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get => this.fullName;
            set
            {
                this.fullName = this.FirstName + " " + this.LastName;
            }
        }

        public string Email { get; set; }

        public IAddress Address { get; set; }

        public int Age { get; set; }
    }

}

