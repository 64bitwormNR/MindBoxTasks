using System;
using Geometric;
using Geometric.Figures;

namespace MindBoxTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FIGURES AREA:");
            IFigure circle = new Circle(5);
            Console.WriteLine($"Circle area - {circle.GetArea()}");
            var triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"Triangle area - {triangle.GetArea()}, Is rectangular? {triangle.IsRectangular()}");
        }
    }
}
