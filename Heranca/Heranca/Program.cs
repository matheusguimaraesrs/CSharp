using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account conta1 = new Account(1001, "alex", 500);
            Account conta2 = new SavingsAccount(1002, "Maria", 500, 0.1);

            conta1.Withdraw(10);
            conta2.Withdraw(10);
            Console.WriteLine(conta1.Balance);
            Console.WriteLine(conta2.Balance);
        }
    }
}