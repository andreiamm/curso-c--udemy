using System;
using System.Globalization;

namespace ex06_aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Student student = new Student();

            Console.Write("Nome do aluno: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            student.Score1 = double.Parse(Console.ReadLine(), CI);
            student.Score2 = double.Parse(Console.ReadLine(), CI);
            student.Score3 = double.Parse(Console.ReadLine(), CI);

            double finalScore = student.CalculateFinalScore();
            Console.WriteLine("NOTA FINAL = " + finalScore.ToString("F2", CI));

            if (student.Passed())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {(student.CalculateMissingScore()).ToString("F2", CI)} PONTOS");
            }
        }
    }
}
