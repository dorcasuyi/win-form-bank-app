using System.Collections.Generic;

namespace DCity_Bank_Core.Interface
{
    public interface ITransactionepo
    {
        List<string> AccountStatement(string ID, string accType);
        bool DepsoitToAccount(string reciever, string depositAmount, string remark);
        List<string> GetTransactionFive(string ID);
        bool InitialDeposit(string CustID, string reciever, string Initamount);
        string transfer(string UserID, string recieverAccount, decimal amount, string remark, string UserAcctType);
        bool Withdraw(string ID, decimal amount, string remark, string accountType);
    }
}