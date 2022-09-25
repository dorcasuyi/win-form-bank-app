using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Account
    {
        public string AccountNumber { get; set; }

        public string AccountID { get; set; }
        public string CustomerID { get; set; }

        public string AccountName { get; set; }
        public string AccountType { get; set; }

        public string Email { get; set; }

        public DateTime CreatedDate { get; set; }

        public Account(string AccID, string CustID, string accountNumber, string accountType, string firstName, string lastName)
        {
            CustomerID = CustID;
            AccountNumber = AccID;
            AccountNumber = accountNumber;
            AccountType = accountType;
            //Email = email;
            CreatedDate = DateTime.Now;
            AccountName = firstName + "," + lastName;
        }
    }
}
