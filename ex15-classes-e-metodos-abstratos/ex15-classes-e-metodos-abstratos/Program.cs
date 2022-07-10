using ex15_classes_e_metodos_abstratos.Entities;
using ex15_classes_e_metodos_abstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ex15_classes_e_metodos_abstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char shapeType = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Enum.TryParse(Console.ReadLine(), out Color color);

                if (shapeType == 'r' || shapeType == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CI);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CI);

                    list.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CI);

                    list.Add(new Circle(color, radius));
                }
            }
           
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CI));
            }
        }
    }
}
