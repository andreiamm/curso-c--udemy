﻿using System.Globalization;

namespace ex13_polimorfismo.Entities
{
    internal class Employee
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            return Name + " - $ "
                   + Payment().ToString("F2", CI);
        }
    }
}
