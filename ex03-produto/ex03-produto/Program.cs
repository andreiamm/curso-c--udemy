using System;
using System.Globalization;

namespace ex03_produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Product prod = new Product();  

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            prod.Name = Console.ReadLine();
            Console.Write("Preço: ");
            prod.Price = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade no estoque: ");
            prod.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + prod);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            int productsToAdd = int.Parse(Console.ReadLine());
            prod.AddProducts(productsToAdd);
            Console.WriteLine("\nDados atualizados: " + prod);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            int productsToRemove = int.Parse(Console.ReadLine());
            prod.RemoveProducts(productsToRemove);
            Console.WriteLine("\nDados atualizados: " + prod);
        }
    }
}
