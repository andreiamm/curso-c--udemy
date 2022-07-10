using ex12_heranca.Entities;
using System;
using System.Globalization;

namespace ex12_heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            Account bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);        
        }
    }
}
