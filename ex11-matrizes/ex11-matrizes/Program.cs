using System;

namespace ex11_matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a dimensão da matriz quadrada? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            Console.WriteLine();
            Console.WriteLine("Valores da Matriz:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Diagonal Principal:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            int negatives = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] < 0)
                    {
                        negatives++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Quantidade de números negativos: " + negatives);
        }
    }
}
