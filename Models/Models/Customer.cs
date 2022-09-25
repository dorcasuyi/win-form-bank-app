using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerID { get; set; }
        public DateTime Date { get; set; }

        public Customer(string firstName, string lastName, string email, string phoneNumber, string customerAddress, string customerID)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            CustomerAddress = customerAddress;
            CustomerID = customerID;
            Date = DateTime.Now;
        }
    }
}
