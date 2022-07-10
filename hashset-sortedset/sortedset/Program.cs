using System.Collections.Generic;

namespace sortedset
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedSet<int> a = new SortedSet<int>() { 6, 5, 4, 3, 2, 1, 0 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
            Console.Write("Coleção a: ");
            PrintCollection(a);
            Console.Write("Coleção b: ");
            PrintCollection(b);

            // union
            SortedSet<int> c = new SortedSet<int>(a); // inicia c com os valores de a
            c.UnionWith(b);
            Console.Write("Coleção c (união de a com b): ");
            PrintCollection(c);

            // intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            Console.Write("Coleção d (interseção de a e b): ");
            PrintCollection(d);

            // difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            Console.Write("Coleção e (exclusão de b contido em a): ");
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
                Console.Write(obj + " ");

            Console.WriteLine();
        }

        /* IEnumerable é uma interface implementada por todas as coleções 
           básicas do namespace System.Collections. Ela tem uma função
           chamada GetEnumerator() que retorna em Enumerator para que se
           possa percorrer a coleção. */

    }
}