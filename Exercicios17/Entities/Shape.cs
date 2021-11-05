


using Exercicio03.Entities.Enums;

namespace Exercicio03.Entities
{
    abstract class Shape
    {

        public Color Color { get; set; }
        protected Shape()
        {
        }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
