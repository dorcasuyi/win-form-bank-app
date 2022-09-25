using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Transaction
    {
        public string TransactionID { get; set; }

        public string Account { get; set; }

        public decimal Amount { get; set; }

        public string Description { get; set; }

        public string TransactionDate { get; set; }

        public Transaction(string account, decimal amount,string description)
        {
            TransactionID = IDGenerator(1, 530254);
            Account = account;
            Amount = amount;
            Description = description;
            TransactionDate = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private static string IDGenerator(int start, int end)
        {
            Random random = new Random();

            string TransID = "ALV" + random.Next(start, end).ToString();
            return TransID;
        }
    }
}
