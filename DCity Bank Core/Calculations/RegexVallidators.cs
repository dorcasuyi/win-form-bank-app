using DCity_Bank_Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DCity_Bank_Core.Helper
{
    public class RegexVallidators : IRegexVallidators
    {
        public bool CheckEmail(string email)
        {
            string strRegex = @"^[a-z]+[0-9a-zA-Z_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return PerformRegEx(strRegex, email);
        }
        public bool CheckPoneNumber(string phoneNumber)
        {
            string strRegex = @"^[0-9]{11}";
            return PerformRegEx(strRegex, phoneNumber);
        }
        public bool CheckName(string name)
        {
            string strRegex = @"^[A-Z]";
            return PerformRegEx(strRegex, name);
        }
        public bool CheckPassword(string password)
        {
            string strRegex = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%#?&])[A-Za-z\d@$!%*#?&]{6,}$";
            return PerformRegEx(strRegex, password);
        }
        private bool PerformRegEx(string pattern, string value)
        {
            Regex re = new Regex(pattern);

            if (re.IsMatch(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
