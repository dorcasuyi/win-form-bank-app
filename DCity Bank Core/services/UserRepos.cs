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
    public class UserRepos : IUserRepos
    {
        readonly IWriteandRead writeRead;
        readonly IUtilities utilities;

        public UserRepos(IWriteandRead writeRead, IUtilities utilities)
        {
            this.writeRead = writeRead;
            this.utilities = utilities;
        }
    
        public string GetCustomerDetails(string custID)
        {
            string path = Filepath.CustomerPath;
            List<string> data = new List<string>();
            data = writeRead.readFile(path);
            string cust = "";

            foreach (var item in data)
            {
                if (item.Split(",")[0] == custID)
                {
                    return cust = item;
                }
            }
            return cust;
        }
        public string Add_NewCustomer(List<string> CustomerDetails)
        {
            CustomerDetails[0] = utilities.removeCharacter(CustomerDetails[0]);
            CustomerDetails[0] = utilities.ConvertToTitle(CustomerDetails[0]);

            CustomerDetails[1] = utilities.removeCharacter(CustomerDetails[1]);
            CustomerDetails[1] = utilities.ConvertToTitle(CustomerDetails[1]);


            string ID = utilities.CustomerIDGenerator();

            List<string> data = new List<string>();
            string path = Filepath.LoginPath;
            data = writeRead.readFile(path);
            string line = data[data.Count - 1];
            string email = line.Split(",")[1];

            Customer customer = new Customer(CustomerDetails[0], CustomerDetails[1], email, CustomerDetails[2], CustomerDetails[3], ID);
            data.Clear();

            path = Filepath.CustomerPath;
            data.Add(customer.CustomerID + "," + customer.FirstName + "," + customer.LastName + "," + customer.Email + "," + customer.PhoneNumber + "," + customer.CustomerAddress);

            if (writeRead.WriteToFile(path, data))
            {
                return ID;
            }
            return "ERROR";
        }
    }
}
