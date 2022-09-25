using DCity_Bank_Core.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCity_Bank_Core.services 
{
    public class UserAuthentication : IUserAuthentication
    {
        readonly IRegexVallidators regex;
        readonly IWriteandRead writeRead;

        public UserAuthentication(IRegexVallidators regex, IWriteandRead writeRead)
        {
            this.regex = regex;
            this.writeRead = writeRead;
        }

        public string LogIn(string email, string Password)
        {
            string message = CheckIfEmpty(email, Password);
            if (message != "OK")
            {
                return message;
            }
            if (!regex.CheckEmail(email))
            {
                return "Invalid Email, Please Use a Valid Email";
            }
            if (AuthLoginCredentials(email, Password))
            {
                return "OK";
            }
            else
            {
                return "Incorrect Login Details";
            }

            return message = "Email Does Not Exist";
        }
        public string CheckIfEmpty(string email, string password)
        {
            if (!string.IsNullOrEmpty(email))
            {
                if (!string.IsNullOrEmpty(password))
                {
                    return "OK";
                }
                else
                {
                    return "The Passwprd Field Is Empty Check And Try Again";
                }
            }
            else
            {
                return "Email Field Is Empty Check And Try Again ";
            }
        }
        public bool AuthLoginCredentials(string email, string password)
        {
            string path = Filepath.LoginPath;
            List<string> data = new List<string>();
            data = writeRead.readFile(path);

            foreach (var item in data)
            {
                if (item.Split(",")[1] == email)
                {
                    string passwrd = item.Split(",")[2];
                    if (passwrd == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool CheckIfEmailExist(string email)
        {
            List<string> data = new List<string>();
            string path = Filepath.LoginPath;
            data = writeRead.readFile(path);

            foreach (var item in data)
            {
                string eamilCheck = item.Split(",")[3];
                if (eamilCheck == email)
                {
                    return true;
                }
            }
            return false;
        }
        public string GetLoginCustomerByID()
        {
            List<string> data = new List<string>();
            string path = Filepath.LogInSessionPath;
            data = writeRead.readFile(path);

            string line = data[data.Count - 1];

            string Id = line.Split(",")[0];

            return Id;
        }
        public string getCustomerByEmail(string email)
        {
            string path = Filepath.CustomerPath;
            List<string> data = new List<string>();
            data = writeRead.readFile(path);
            string CustEmail = "";

            foreach (var item in data)
            {
                if (item.Split(",")[3] == email)
                {
                    return CustEmail = item;
                }
            }
            return CustEmail;
        }
        public void SetLog(string email)
        {
            string path = Filepath.LogInSessionPath;
            List<string> data = new List<string>();
            string item = getCustomerByEmail(email).Trim();
            data.Add(item);
            writeRead.WriteToFile(path, data);
        }
    }
}
