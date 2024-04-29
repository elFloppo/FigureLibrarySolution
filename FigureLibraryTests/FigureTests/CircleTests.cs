using FigureLibrary.Figures;
using Xunit;

namespace FigureLibraryTests.FigureTests
{
    public class CircleTests
    {
        [Fact]
        public void CircleParametersTest()
        {
            var circle = new Circle(5);

            Assert.Equal(Math.PI * 10, circle.Perimeter);
            Assert.Equal(Math.PI * 25, circle.Area);
        }

        [Fact]
        public void MaxDoubleRadiusTest()
        {
            var circle = new Circle(double.MaxValue);
            Assert.Throws<ArgumentException>(() => circle.Perimeter);
            Assert.Throws<ArgumentException>(() => circle.Area);
        }

        [Fact]
        public void NegativeRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-6));
        }

        [Fact]
        public void RadiusSetterTest()
        {
            var circle = new Circle(7);
            Assert.Throws<ArgumentException>(() => circle.Radius = -7);
        }
    }
}
