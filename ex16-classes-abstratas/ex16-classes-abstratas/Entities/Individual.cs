namespace ex16_classes_abstratas.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) 
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double taxPercentage = (AnualIncome < 20000.0) ? 0.15 : 0.25;

            return AnualIncome * taxPercentage - HealthExpenditures * 0.5;
        }
    }
}
