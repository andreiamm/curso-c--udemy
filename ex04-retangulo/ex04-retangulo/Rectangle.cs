using System;

namespace ex04_retangulo
{
    internal class Rectangle
    {

        public double Width;
        public double Height;

        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return 2.0 * (Width + Height);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Width, 2.0) + Math.Pow(Height, 2.0));
        }
    }
}
