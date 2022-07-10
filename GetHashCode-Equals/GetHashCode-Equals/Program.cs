using GetHashCode_Equals.Entities;

Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };
Client c = new Client { Name = "Alex", Email = "maria@gmail.com" };

Console.WriteLine(a.Equals(b));
Console.WriteLine(a.Equals(c));
Console.WriteLine(a == c); // compara os ponteiros (referência de memória)
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
Console.WriteLine(c.GetHashCode());
