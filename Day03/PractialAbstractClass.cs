using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Day03
{
    abstract class Account
    {
        public int AccountID { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; private set; } = 5000;
        public void Credit(double amount) => Balance += amount;
        public void Debit(double amount)
        {
            if (Balance < amount)
                throw new Exception("Insufficient Funds");
            else
                Balance -= amount;
        }

        public abstract void CalculateInterest();
    }

    class SBAccount : Account
    {
        public override void CalculateInterest()
        {
            double bal = Balance;
            double rate = 6.5 / 100;
            double term = 0.25;
            double interest = bal * rate * term;
            Credit(interest);
        }
    }
    class PractialAbstractClass
    {
        static void Main(string[] args)
        {
            Account acc = new SBAccount { AccountHolder = "Phaniraj", AccountID = 111 };
            acc.Credit(50000);
            acc.CalculateInterest();
            Console.WriteLine($"The current balance is {acc.Balance}");
        }
    }
}
