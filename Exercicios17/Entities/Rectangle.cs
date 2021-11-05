
using Exercicio03.Entities.Enums;

namespace Exercicio03.Entities
{
    class Retangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }
        public Retangle()
        {
        }

        public Retangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
