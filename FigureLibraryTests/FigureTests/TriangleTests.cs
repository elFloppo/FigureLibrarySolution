using FigureLibrary.Figures;
using Xunit;

namespace FigureLibraryTests.FigureTests
{
    public class TriangleTests
    {
        [Fact]
        public void TriangleParametersTest()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.Equal(6, triangle.Area);
            Assert.Equal(6, triangle.Perimeter);
        }

        [Fact]
        public void RightTriangleTest()
        {
            Assert.True(new Triangle(3, 4, 5).IsTriangleRight);
            Assert.False(new Triangle(6, 6, 6).IsTriangleRight);
        }

        [Fact]
        public void MaxDoubleSidesTest()
        {
            var triangle = new Triangle(double.MaxValue, double.MaxValue, double.MaxValue);
            Assert.Throws<ArgumentException>(() => triangle.Perimeter);
            Assert.Throws<ArgumentException>(() => triangle.Area);
            Assert.Throws<ArgumentException>(() => triangle.IsTriangleRight);
        }

        [Fact]
        public void NegativeSideTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-6, 0, 0));
            Assert.Throws<ArgumentException>(() => new Triangle(0, -6, 0));
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, -6));
        }

        [Fact]
        public void WrongTriangleTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(666, 6, 6));
        }

        [Fact]
        public void SideSettersTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Throws<ArgumentException>(() => triangle.A = -7);
            Assert.Throws<ArgumentException>(() => triangle.B = 666);
            Assert.Throws<ArgumentException>(() => triangle.C = -666);
        }
    }
}
