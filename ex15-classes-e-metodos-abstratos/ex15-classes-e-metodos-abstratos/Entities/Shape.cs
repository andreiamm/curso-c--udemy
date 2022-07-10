using ex15_classes_e_metodos_abstratos.Entities.Enums;


namespace ex15_classes_e_metodos_abstratos.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
