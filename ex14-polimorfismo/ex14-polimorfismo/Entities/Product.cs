﻿using System.Globalization;

namespace ex14_polimorfismo.Entities
{
    internal class Product
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $ " 
                   + Price.ToString("F2", CI);
        }
    }
}
