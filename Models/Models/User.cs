using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class User
    {
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public string UserID { get; set; }

        public User(string userEmail, string password, string userID)
        {
            UserEmail = userEmail;
            Password = password;
            UserID = userID;
        }
    }
}
