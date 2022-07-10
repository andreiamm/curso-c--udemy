using System.Globalization;
using System;

namespace exercicio26_icomparable.Entities
{
    internal class Employee : IComparable
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] items = csvEmployee.Split(",");
            Name = items[0];
            Salary = double.Parse(items[1], CI);
        }

        public override string ToString()
        {
            return Name + "," + Salary.ToString("F2", CI);
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an employee");
            }
            Employee other = (Employee)obj;
            return Name.CompareTo(other.Name);
        }
    }
}
