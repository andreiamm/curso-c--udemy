using System;

namespace ex12_matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Console.Write("Number of lines: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Number of Columns: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];
            string[] sub = new string[n];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                string s = Console.ReadLine();
                sub = s.Split(' ');
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = Convert.ToInt32(sub[j]);
                }
            }
          
            Console.WriteLine();
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());


            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == number)
                    {
                        Console.WriteLine($"Position {i},{j}:");
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {mat[i,j - 1]}");
                        }
                        if (j < mat.GetLength(1) - 1)
                        {
                            Console.WriteLine($"Right: {mat[i,j+ 1]}");
                        }
                        if (i < mat.GetLength(0) - 1)
                        {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
