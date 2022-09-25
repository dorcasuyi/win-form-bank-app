using DCity_Bank_Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DCity_Bank_Core.Calculations
{
    public class Utilities : IUtilities
    {
        Random random = new Random();
        public string ComputeSha256Hash(string rawData)
        {
            // Creating a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public string CustomerIDGenerator()
        {
            string ID = "DOR" + random.Next(50, 300);
            return ID;
        }
        public string removeCharacter(string str)
        {
            string chars = new string(str.Where(c => c != '-' && (c < '0' || c > '9')).ToArray());
            return chars;
        }
        public string ConvertToTitle(string str)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
        }

        public string GenerateAccNumber(int length)
        {
            string prefix = "";
            for (int i = 0; i < length; i++)
            {
                prefix = string.Concat(prefix, random.Next(6)).ToString();
            }
            return "2040" + prefix;

        }
        public string GenerateAccID()
        {
            string ID = "CHI" + random.Next(50, 300);
            return ID;
        }
    }
}
