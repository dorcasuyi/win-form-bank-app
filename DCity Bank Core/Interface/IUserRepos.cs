using System.Collections.Generic;

namespace DCity_Bank_Core.Interface
{
    public interface IUserRepos
    {
        string Add_NewCustomer(List<string> CustomerDetails);
        string GetCustomerDetails(string custID);
    }
}