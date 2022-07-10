using generics_restrito.Services;
using generics_restrito.Entities;
using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

/************ INTEGERS ***********/
List<int> list = new List<int>();

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    list.Add(x);
}

CalculationService cs = new CalculationService();
Console.WriteLine("\nGreater: " + cs.Max(list));
Console.WriteLine();

/************ OBJECTS ***********/
List<Product> prod = new List<Product>();

Console.Write("Enter N: ");
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] vect = Console.ReadLine().Split(',');
    prod.Add(new Product(vect[0], double.Parse(vect[1], CI)));
}

CalculationService cs2 = new CalculationService();
Console.WriteLine("\nMost expensive: " + cs2.Max(prod));
