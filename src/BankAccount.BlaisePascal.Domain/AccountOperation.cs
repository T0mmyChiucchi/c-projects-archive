using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.BlaisePascal.Domain
{
    public class AccountOperation
    {
        public double Import { get; set; }
        public DateTime Date { get; set; }

        public AccountOperation(double import, DateTime date)
        {
            Import = import;
            Date = date;
        }

        public string Status()
        {
            string status = Import >= 0 ? "Deposit" : "Withdrawal";

            return $"{status} of {Import}$ made on the date {Date}";
        }
    }
}
