using System.Reflection.Metadata.Ecma335;

namespace BankAccount.BlaisePascal.Domain
{
    public class BankAccount
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Balance { get; set; }

        public BankAccount(Guid id, string name, double balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }

        public virtual void Deposit(int amount)
        {
            Balance += amount;
        }

        public virtual void Withdrawal(int amount)
        {
            if (Balance - amount < 0)
            {
                Balance -= amount;
            }
        }

        public void AddInterest()
        {
            if(Balance >= 100 && Balance <= 1000)
            {
                Balance *= 1.02;
            } else if(Balance > 1000)
            {
                Balance *= 1.04;
            }
        }

        public string BankAccountDescription()
        {
            return $"The Bank Account number {Id} that is attested to {Name} has a balance of {Balance}$";
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
}
