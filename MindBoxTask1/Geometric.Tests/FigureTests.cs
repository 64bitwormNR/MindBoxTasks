using System;
using Xunit;
using Geometric.Figures;

namespace Geometric.Tests
{
    public class FigureTests
    {
        [Fact]
        public void CheckCircleArea()
        {
            Assert.Equal(Math.PI, new Circle(1).GetArea());
        }

        [Fact]
        public void CheckTriangleArea()
        {
            Assert.Equal(6, new Triangle(3, 4, 5).GetArea());
        }

        [Fact]
        public void CheckIsTriangleRight()
        {
            Assert.True(new Triangle(3, 4, 5).IsRectangular());
        }

        [Fact]
        public void CheckIsTriangleNotRight()
        {
            Assert.False(new Triangle(30, 45, 50).IsRectangular());
        }
    }
}
