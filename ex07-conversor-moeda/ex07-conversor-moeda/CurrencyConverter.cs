namespace ex07_conversor_moeda
{
    internal class CurrencyConverter
    {
        public static double Tax = 0.06;
        public static double Convert(double rate, double amount)
        {
            return rate * amount + (rate * amount * Tax);
        }
    }
}
