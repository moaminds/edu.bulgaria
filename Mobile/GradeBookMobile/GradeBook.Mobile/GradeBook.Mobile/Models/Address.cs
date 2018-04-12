using GradeBook.Mobile.Interfaces;

namespace GradeBook.Mobile.Models
{
    public class Address : IAddress
    {
        public Address(string city, string zipCode, string street)
        {
            this.City = city;
            this.ZipCode = zipCode;
            this.Street = street;
        }

        public string City { get; set; }
        
        public string ZipCode { get; set; }

        public string Street { get; set; } 

    }
}
