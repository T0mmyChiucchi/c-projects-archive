using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.BlaisePascal.Domain
{
    public class Bank
    {
        public List<BankAccountPlus> Accounts { get; set; }

        public Bank()
        {
            Accounts = new List<BankAccountPlus>();
        }

        public void CreateAccount(BankAccountPlus newAccount)
        {
            Accounts.Add(newAccount);
        }

        public string ViewAccount(Guid id)
        {
            string n = "";
            for(int i=0;i<Accounts.Count; i++)
            {
                if (Accounts[i].Id == id)
                {
                    n = Accounts[i].BankAccountDescription();
                }
            }
            return n;
        }

        public string Person()
        {
            HashSet<string> names = new();
            for(int i=0; i<Accounts.Count; i++)
            {
                names.Add(Accounts[i].Name);
            }
            int[] numbers = new int[names.Count];

            for (int i = 0; i < names.Count; i++)
            {
                numbers[i] = 0;

                for(int j = 0; j < Accounts.Count; j++)
                {
                    if (names.ElementAt(i) == Accounts[j].Name)
                    {
                        numbers[i]++;
                    }
                }
            }
            int c = 0;
            int index = 0;
            for(int i=0; i < numbers.Length; i++)
            {
                if (numbers[i] > c)
                {
                    c = numbers[i];
                    index = i;
                }
            }
            return names.ElementAt(index);
        }

        public string PersonWithAccountPlusWithMostOperations()
        {
            int c = 0;
            int index = 0;
            for(int i=0;i<Accounts.Count;i++)
            {
                if (Accounts[i] is BankAccountPlus)
                {
                    if (Accounts[i].AccountOperations.Count > c)
                    {
                        c = Accounts[i].AccountOperations.Count;
                        index = i;
                    }
                }
            }
            return Accounts[index].Name;
        }

        //public List<string> PersonBigWithdrawal()
        //{

        //}
    }
}
