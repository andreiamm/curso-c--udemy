using func.Entities;
using System.Linq;

List<Product> list = new List<Product>();

list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

/* Delegate que é referência pra uma função que recebe
 * um Product e retorna uma string */
Func<Product, string> func = p => p.Name.ToUpper();

// .ToList() converte IEnumerable, que é uma coleção mais genérica, em lista.
List<string> result = list.Select(func).ToList();

/* Opção com a expressão lambda inline (dispensa a declaração de func)
 * List<string> result = list.Select(p => p.Name.ToUpper()).ToList(); */

foreach (string s in result)
    Console.WriteLine(s);
