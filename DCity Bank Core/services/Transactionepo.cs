using DCity_Bank_Core.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCity_Bank_Core.services
{
    public class Transactionepo : ITransactionepo
    {
        readonly IWriteandRead WriteandRead;
        readonly IAccountRepo AccountPopulator;

        public Transactionepo(IWriteandRead writeandRead, IAccountRepo accountPopulator)
        {
            WriteandRead = writeandRead;
            AccountPopulator = accountPopulator;
        }

        public bool InitialDeposit(string CustID, string reciever, string Initamount)
        {
            string path = Filepath.TransactionPath;

            decimal depositamount = decimal.Parse(Initamount);
            string Transactiontype = "Initial Deposit";
            string remark = "Account Opening";

            List<string> data = new List<string>();

            Transaction transc = new Transaction(reciever, depositamount, remark);

            data.Add(transc.TransactionID + "," + reciever + "," + depositamount + "," + Transactiontype + "," + remark);

            return true;
        }
        public bool DepsoitToAccount(string reciever, string depositAmount, string remark)
        {
            decimal amount = decimal.Parse(depositAmount);
            List<string> data = new List<string>();

            Transaction newTrans = new Transaction(reciever, amount, remark);
            data.Add(newTrans.TransactionID + "," + reciever + "," + newTrans.Amount + "," + newTrans.TransactionDate + "," + newTrans.Description);


            string path = Filepath.TransactionPath;
            WriteandRead.WriteToFile(path, data);
            return true;
        }
        public bool Withdraw(string ID, decimal amount, string remark, string accountType)
        {
            List<string> data = new List<string>();
            string Acctnum = "";
            data = AccountPopulator.getAccountByID(ID);
            foreach (var item in data)
            {
                Acctnum = item.Split(",")[4];
                break;
            }

            data.Clear();

            Transaction transaction = new Transaction(Acctnum, amount, remark);
            data.Add(transaction.TransactionID + "," + Acctnum + "," + transaction.Amount + "," + transaction.TransactionDate + "," + transaction.Description);

            string path = Filepath.TransactionPath;
            WriteandRead.WriteToFile(path, data);
            return true;
        }
        public List<string> GetTransactionFive(string ID)
        {
            List<string> latestTransactions = new List<string>();

            string path = Filepath.TransactionPath;

            latestTransactions = WriteandRead.readFile(path);


            return latestTransactions;
        }

        public string transfer(string UserID, string recieverAccount, decimal amount, string remark, string UserAcctType)
        {
            string UserAccNum = AccountPopulator.GetAccountByIDandType(UserID, UserAcctType);
            string message = "";

            string TransferedAmount = amount.ToString();
            string stringamount = amount.ToString();
            stringamount += "-";
            decimal amounttoBeTransfered = decimal.Parse(stringamount);

            if (UserAccNum == recieverAccount)
            {
                return message = "Invalid Operation, You Can't transfer To Your Self";
            }
            else
            {
                DepsoitToAccount(recieverAccount, TransferedAmount, remark);
                Withdraw(UserID, amounttoBeTransfered, remark, UserAcctType);
                return message = "OK";
            }
        }
        public List<string> AccountStatement(string ID, string accType)
        {
            List<string> data = new List<string>();
            List<string> accountStatements = new List<string>();
            string AccNum = AccountPopulator.GetAccountByIDandType(ID, accType);
            List<string> validate = new List<string> { "boy", "girl" };

            if (AccNum == "")
            {
                return validate ;
            }
            else
            {
                string path = Filepath.TransactionPath;
                data = WriteandRead.readFile(path);

                foreach (var item in data)
                {
                    if (item.Split(",")[1] == AccNum)
                    {
                        accountStatements.Add(item);
                    }
                }
            }
            return accountStatements;
        }

    }
}
