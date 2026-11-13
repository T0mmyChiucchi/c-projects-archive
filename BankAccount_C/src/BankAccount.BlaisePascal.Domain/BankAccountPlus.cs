using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.BlaisePascal.Domain
{
    public class BankAccountPlus: BankAccount
    {
        public List<AccountOperation> AccountOperations { get; set; }
        public BankAccountPlus(Guid id, string name, double balance) : base(id, name, balance)
        {
            AccountOperations = new List<AccountOperation>();
        }

        public string PrintMovementList()
        {
            return $"List of account operations: {AccountOperations}";
        }

        public override void Deposit(int amount)
        {
            base.Deposit(amount);
            AccountOperation a = new(amount, DateTime.Now);
            AccountOperations.Add(a);
        }
        public override void Withdrawal(int amount)
        {
            base.Withdrawal(amount);
            AccountOperation a = new(amount, DateTime.Now);
            AccountOperations.Add(a);
        }
    }
}
