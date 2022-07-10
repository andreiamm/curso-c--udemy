namespace ex16_classes_abstratas.Entities
{
    internal class Company : TaxPayer
    {

        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) 
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double taxPercentage = (NumberOfEmployees > 10) ? 0.14 : 0.16;

            return AnualIncome * taxPercentage;
        }
    }
}
