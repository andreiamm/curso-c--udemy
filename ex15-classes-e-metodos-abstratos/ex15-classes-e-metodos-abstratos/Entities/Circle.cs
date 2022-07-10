using ex15_classes_e_metodos_abstratos.Entities.Enums;
using System;

namespace ex15_classes_e_metodos_abstratos.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius)
            : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
