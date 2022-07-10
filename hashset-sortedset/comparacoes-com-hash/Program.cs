using comparacoes_com_hash.Entities;

// COMPARAÇÃO COM TIPO REFERÊNCIA (CLASSE)
HashSet<Product> a = new HashSet<Product>();
a.Add(new Product("TV", 900.0));
a.Add(new Product("Notebook", 1200.0));

/* Criação de novo objeto, que aponta para um local
   diferente na memória, mesmo que o conteúdo seja igual */
Product prod = new Product("Notebook", 1200.0);

/* Sem implementar o GetHashCode e o Equals na classe
   Product, essa comparação retorna False. Após a 
   implementação dos dois, retorna True, pois não 
   estará mais comparando referência, e sim conteúdo. */
Console.WriteLine(a.Contains(prod));


// COMPARAÇÃO COM TIPO VALOR (STRUCT)
HashSet<Point> b = new HashSet<Point>();
b.Add(new Point(3, 4));
b.Add(new Point(5, 10));

Point p = new Point(3, 4);
Console.WriteLine(b.Contains(p)); // retorna True.
