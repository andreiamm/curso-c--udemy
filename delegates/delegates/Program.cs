using delegates.Services;
using System;

namespace Course
{
    /* Declaração do delegate. Diz que será uma referência para uma função que
     * recebe 2 números double e retorna um número double. */
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            /* O delegate op passa a ser uma referência para a função Sum. */
            BinaryNumericOperation op = CalculationService.Sum;
            double result1 = op(a, b);
            // double result1 = op.Invoke(a, b); também funciona
            Console.WriteLine(result1);

            /* outra forma mais verbosa de se instanciar */
            BinaryNumericOperation op2 = new BinaryNumericOperation(CalculationService.Max);
            double result2 = op2(a, b);
            Console.WriteLine(result2);

            /* A referência não funcionará com a função Square pois ela só recebe 1 parâmetro */
            double result3 = CalculationService.Square(b);
            Console.WriteLine(result3);
        }
    }
}
