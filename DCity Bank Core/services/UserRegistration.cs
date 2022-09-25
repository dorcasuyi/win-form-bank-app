using DCity_Bank_Core.Interface;
using Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCity_Bank_Core.services
{
    public class UserRegistration : IUserRegistration
    {
        readonly IUserAuthentication customerAuthentications;
        readonly IRegexVallidators regex;
        readonly IWriteandRead writeandRead;

        public UserRegistration(IUserAuthentication customerAuthentications, IRegexVallidators regex, IWriteandRead writeandRead)
        {
            this.customerAuthentications = customerAuthentications;
            this.regex = regex;
            this.writeandRead = writeandRead;
          
        }
        Random random = new Random();
        public string UserIDGenerator()
        {
            string ID = "JOY" + random.Next(50, 600);
            return ID;
        }
        public string RegisterCustomer(string email, string Password)
        {
            string ID = "";
            string message = customerAuthentications.CheckIfEmpty(email, Password);
            if (message != "OK")
            {
                return message;
            }
            if (!regex.CheckEmail(email))
            {
                return message = "Invalid Email, Please Try Again with a valid Email";
            }
            if (customerAuthentications.CheckIfEmailExist(email))
            {
                return message = "This Email Is Already Registerd, Please Try Again With Another detail.";
            }

            ID = UserIDGenerator();

            string path = Filepath.LoginPath;

            List<string> data = new List<string>();
            User user = new User(email, Password, ID);
            data.Add(user.UserID + "," + user.UserEmail + "," + user.Password);
            writeandRead.WriteToFile(path, data);

            return message;

        }
    }
}
