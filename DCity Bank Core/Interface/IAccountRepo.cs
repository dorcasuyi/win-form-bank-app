using System.Collections.Generic;

namespace DCity_Bank_Core.Interface
{
    public interface IAccountRepo
    {
        decimal checkBalance(string CustID, string accType);
        string confirmAccount(string accNum);
        bool CreatNewAccount(string CustID, string initialDeposit, string accType);
        List<string> getAccountByID(string ID);
        string GetAccountByIDandType(string ID, string type);
    }
}