using ex20_composicao.Entities;
using ex20_composicao.Entities.Enums;
using System;
using System.Globalization;

namespace ex20_composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            Console.Write("status: ");
            Enum.TryParse(Console.ReadLine(), out OrderStatus status);

            Order order = new Order(DateTime.Now, status, new Client(name, email, birth));

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string product = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CI);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                order.AddItem(new OrderItem(quantity, price, new Product(product, price)));
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
