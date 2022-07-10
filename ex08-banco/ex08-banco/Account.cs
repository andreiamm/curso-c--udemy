using System.Globalization;

namespace ex08_banco
{
    internal class Account
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public int AccountNumber { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public Account(int accountNumber, string holder)
        {
            AccountNumber = accountNumber;
            Holder = holder;
            Balance = 0.0;
        }

        public Account(int accountNumber, string holder, double deposit) : this(accountNumber, holder)
        {
            Deposit(deposit);
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public void Withdraw(double value)
        {
            Balance -= value + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + AccountNumber
                   + ", Titular: " + Holder
                   + ", Saldo: $ " + Balance.ToString("F2", CI);
        }
    }
}
