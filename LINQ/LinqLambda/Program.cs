using LinqLambda.Entities;

static void Print<T>(string message, IEnumerable<T> collection)
{
    Console.WriteLine(message);
    foreach (T obj in collection)
    {
        Console.WriteLine(obj);
    }
    Console.WriteLine();
}

Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

List<Product> products = new List<Product>()
{
    new Product() { Id = 1, Name="Computer", Price = 1100.0, Category = c2 },
    new Product() { Id = 2, Name="Hammer", Price = 90.0, Category = c1 },
    new Product() { Id = 3, Name="TV", Price = 1700.0, Category = c3 },
    new Product() { Id = 4, Name="Notebook", Price = 1300.0, Category = c2 },
    new Product() { Id = 5, Name="Saw", Price = 80.0, Category = c1 },
    new Product() { Id = 6, Name="Tablet", Price = 700.0, Category = c2 },
    new Product() { Id = 7, Name="Camera", Price = 700.0, Category = c3 },
    new Product() { Id = 8, Name="Printer", Price = 350.0, Category = c3 },
    new Product() { Id = 9, Name="MacBook", Price = 1800.0, Category = c2 },
    new Product() { Id = 10, Name="Sound Bar", Price = 700.0, Category = c3 },
    new Product() { Id = 11, Name="Level", Price = 70.0, Category = c1 },
};

/* Como não foi usado o select, exibirá no resultado o que foi setado no ToString() da classe. */
var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
/* Alternativa de notação similar ao SQL
 * var r1 =
 *     from p in products
 *     where p.Category.Tier == 1 && p.Price < 900.0
 *     select p; */
Print("TIER 1 AND PRICE < 900: ", r1);

/* Com o Select é possível escolher apenas uma propriedade (no caso nome) para exibir no resultado.
 * É como se fosse a query de SQL select Name from products */
var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
/* Sintaxe alternativa
 * var r2 =
 *    from p in products
 *    where p.Category.Name == "Tools"
 *    select p.Name; */
Print("NAMES OF PRODUCTS FROM TOOLS", r2);

/* Cria-se um objeto anônimo no Select para poder selecionar mais de uma propriedade. Foi necessário criar um alias 
 * para p.Category.Name (categoryName) porque como já havia uma propriedade chamada Name (p.Name), o compilador reclamou. */
var r3 = products.Where(p => p.Name.StartsWith('C')).Select(p => new { p.Name, p.Price, categoryName = p.Category.Name});
// Também se poderia usar p => p.Name[0] == 'C' para encontrar os produtos que começam com C.
/* Sintaxe alternativa
 * var r3 =
 *    from p in products
 *    where p.Name[0] == 'C'
 *    select new { 
 *      p.Name, 
 *      p.Price, 
 *      categoryName = p.Category.Name
 *      } */
Print("NAMES STARTED WITH C: ", r3);

var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
/* Sintaxe alternativa
 * var r4 =
 *    from p in products
 *    where p.Category.Tier == 1
 *    orderby p.Name, // o order by fica na ordem inversa aqui. Coloca-se por último o principal.
 *    orderby p.Price, 
 *    select p; */
Print("TIER 1 ORDER BY PRICE THEN BY NAME: ", r4);

// Pula os 2 primeiros elementos de r4 e pega os 4 seguintes
var r5 = r4.Skip(2).Take(4);
/* Sintaxe alternativa
 * var r5 =
 *    (from p in r4
 *    select p).Skip(2).Take(4); */
Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4: ", r5);

var r6 = products.FirstOrDefault();
Console.WriteLine("FIRST TEST 1: " + r6);

var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
/* Sintaxe alternativa
 * var r7 =
 *    (from p in products
 *    where p.Price > 3000.0
 *    select p).FirstOrDefault(); */
Console.WriteLine("FIRST TEST 2: " + r7);

var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
Console.WriteLine("SINGLE OR DEFAULT TEST 1: " + r8);

var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
Console.WriteLine("SINGLE OR DEFAULT TEST 2: " + r9);
Console.WriteLine();

var r10 = products.Max(p => p.Price);
Console.WriteLine("MAX PRICE: " + r10);

var r11 = products.Min(p => p.Price);
Console.WriteLine("MIN PRICE: " + r11);

var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
Console.WriteLine("CATEGORY 1 SUM PRICES: " + r12);

var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
Console.WriteLine("CATEGORY 1 AVERAGE PRICE: " + r13);

// retorna 0 porque a categoria 5 não existe.
var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
Console.WriteLine("CATEGORY 5 AVERAGE PRICE: " + r14);

// Aggregate cria uma função anônima que faz a soma de todos os números da coleção. Começa com o valor padrão 0.0.
var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x,y) => x + y);
Console.WriteLine("CATEGORY 1 AGGREGATE SUM: " + r15);
Console.WriteLine();

var r16 = products.GroupBy(p => p.Category);
/* Sintaxe alternativa
 * var r16 =
 *    from p in products
 *    group p by p.Category; */

foreach (IGrouping<Category, Product> group in r16)
{
    Console.WriteLine("Category " + group.Key.Name + ":"); // Key refere-se a Category
    foreach (Product p in group)
    {
        Console.WriteLine(p);
    }
    Console.WriteLine();
}