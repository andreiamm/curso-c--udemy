using exercicio01.entities;
using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

string path = @"c:\temp\input.csv";

List<Product> prod = new List<Product>();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] item = sr.ReadLine().Split(',');
            string name = item[0];
            double price = double.Parse(item[1], CI);

            prod.Add(new Product(name, price));
        }
    }

    var average = prod.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
    Console.WriteLine($"Average price: {average.ToString("F2", CI)}");

    var prodsPriceBelow = prod.Where(p => p.Price < average).OrderByDescending(p => p.Name).Select(p => p.Name);
    foreach (string p in prodsPriceBelow)
    {
        Console.WriteLine(p);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
}
