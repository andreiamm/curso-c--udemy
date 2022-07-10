namespace comparacoes_com_hash.Entities
{
    internal class Product // tipo referência
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            // Soma os 2 hash codes
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Product))
            {
                return false;
            }
            Product other = (Product)obj;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
