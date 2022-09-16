using System;

namespace Geometric.Figures
{
    public class Circle: IFigure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if(radius < 0)
            {
                throw new ArgumentException("A circle cannot have a negative radius");
            }
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
