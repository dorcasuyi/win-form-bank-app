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
    public class AccountRepo : IAccountRepo

    {
        readonly IUtilities utilities;
        readonly IUserRepos CustomerPopulator;
        readonly IWriteandRead WriteandRead;

        public AccountRepo(IUtilities utilities, IUserRepos customerPopulator, IWriteandRead writeandRead)
        {
            this.utilities = utilities;
            CustomerPopulator = customerPopulator;
            WriteandRead = writeandRead;
        }

        public bool CreatNewAccount(string CustID, string initialDeposit, string accType)
        {
            string accNum = utilities.GenerateAccNumber(6);
            string accID = utilities.GenerateAccID();

            string CustData = "";

            CustData = CustomerPopulator.GetCustomerDetails(CustID);
            string firstName = CustData.Split(",")[1];
            string lastName = CustData.Split(",")[2];

            Account account = new Account(accID, CustID, accNum, accType, firstName, lastName);

            List<string> data = new List<string>();
            data.Add(account.AccountID + "," + CustID + "," + account.AccountName + "," + accNum + "," + accType + "," + account.CreatedDate + "," + initialDeposit);
            string path = Filepath.AccountPath;
            WriteandRead.WriteToFile(path, data);

            return true;
        }
        public string confirmAccount(string accNum)
        {
            List<string> data = new List<string>();
            string BufferData = "";
            string path = Filepath.AccountPath;
            data = WriteandRead.readFile(path);

            foreach (var item in data)
            {
                BufferData = item.Split(",")[2] + " " + item.Split(",")[3] + " " + item.Split(",")[4];
                return BufferData;
            }
            return BufferData;
        }
        public List<string> getAccountByID(string ID)
        {
            string path = Filepath.AccountPath;
            List<string> CustAccData = new List<string>();

            CustAccData = WriteandRead.readFile(path);

            List<string> AccDetails = new List<string>();

            foreach (var item in CustAccData)
            {
                if (item.Split(",")[1] == ID)
                {
                    if (item.Split(",")[5] == "Savings")
                    {
                        AccDetails.Add(item);
                    }
                    if (item.Split(",")[5] == "Current")
                    {
                        AccDetails.Add(item);
                    }
                }
            }
            return AccDetails;
        }
        public string GetAccountByIDandType(string ID, string type)
        {
            List<string> data = new List<string>();
            string path = Filepath.AccountPath;
            string accnum = "";
            data = WriteandRead.readFile(path);
            foreach (var item in data)
            {
                if (item.Split(",")[1] == ID && item.Split(",")[5] == type)
                {
                    return accnum = item.Split(",")[4];
                }
            }
            return accnum;
        }
        public decimal checkBalance(string CustID, string accType)
        {
            decimal balance = 0;
            string AccountNumber = "";
            List<string> listOfTransactions = new List<string>();
            AccountNumber = GetAccountByIDandType(CustID, accType);

            if (AccountNumber == "")
            {
                return 0;
            }
            else
            {
                string path = Filepath.TransactionPath;
                listOfTransactions = WriteandRead.readFile(path);
            }

            if (listOfTransactions.Count == 0)
            {
                balance = 0;
            }
            else
            {
                foreach (var item in listOfTransactions)
                {
                    if (item.Split(",")[1] == AccountNumber)
                    {
                        string amount = item.Split(",")[2];
                        decimal amountDecimal = decimal.Parse(amount);
                        balance += amountDecimal;
                    }
                }
            }
            return balance;
        }
    }
}
