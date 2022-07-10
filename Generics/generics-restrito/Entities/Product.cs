using System.Globalization;

namespace generics_restrito.Entities
{
    internal class Product : IComparable
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name
                   + ", "
                   + Price.ToString("F2", CI);
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Product)) {
                throw new ArgumentException("Comparing error: argument is not a product");
            }
            Product other  = (Product)obj;
            return Price.CompareTo(other.Price);
        }
    }
}
