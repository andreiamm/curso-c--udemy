using System;
using System.Globalization;

namespace ex04_retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Rectangle rect = new Rectangle();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            rect.Width = double.Parse(Console.ReadLine(), CI);
            rect.Height = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("AREA = " + rect.Area().ToString("F2", CI));
            Console.WriteLine("PERIMETRO = " + rect.Perimeter().ToString("F2", CI));
            Console.WriteLine("DIAGONAL = " + rect.Diagonal().ToString("F2", CI);
        }
    }
}
