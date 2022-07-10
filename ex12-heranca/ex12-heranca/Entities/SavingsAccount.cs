namespace ex12_heranca.Entities
{
    internal class SavingsAccount : Account
    {

        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void updateBalance()
        {
            Balance += InterestRate;
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }
    }
}
