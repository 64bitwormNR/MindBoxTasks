using System;

namespace Geometric.Figures
{
    public class Triangle: IFigure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if(!IsTriangleValid(sideA, sideB, sideC))
            {
                throw new ArgumentException("Triangle is invalid");
            }
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public bool IsRectangular()
        {
            var sides = new double[]{ SideA, SideB, SideC };
            Array.Sort(sides);
            return sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2] < 1e-10d;
        }

        public double GetArea()
        {
            double semi = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semi * (semi - SideA) * (semi - SideB) * (semi - SideC));
        }

        private bool IsTriangleValid(double sideA, double sideB, double sideC)
        {
            return sideA > 0 && sideB > 0 && sideC > 0 &&
                sideA + sideB > sideC &&
                sideB + sideC > sideA &&
                sideC + sideA > sideB;
        }
    }
}
