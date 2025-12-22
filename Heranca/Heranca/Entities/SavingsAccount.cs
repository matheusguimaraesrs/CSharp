using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interesRate) : base(number, holder, balance)
        {
            InterestRate = interesRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2;
        }
    }
}
