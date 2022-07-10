using System;
using System.Globalization;

namespace exercicio24.Entities
{
    internal class Installment
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("d") + " - " + Amount.ToString("F2", CI);
        }
    }
}
