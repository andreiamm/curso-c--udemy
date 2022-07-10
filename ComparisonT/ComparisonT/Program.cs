using ComparisonT.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 900.00));
list.Add(new Product("Notebook", 1200.00));
list.Add(new Product("Tablet", 450.00));

/* Usando expressão lambda atribuída a uma variável do tipo delegate. 
 * Não é necessário declarar o tipo de p1 e p2, ele será inferido. */
Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
list.Sort(comp);

/* Também é possível usar a expressão lambda inline.
 * list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); */

foreach (Product p in list)
    Console.WriteLine(p);
