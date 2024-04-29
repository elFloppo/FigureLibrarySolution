using FigureLibrary.Figures;
using Xunit;

namespace FigureLibraryTests.FigureTests
{
    public class RectangleTests
    {
        [Fact]
        public void RectangleParametersTest()
        {
            var rectangle = new Rectangle(6, 7);

            Assert.Equal(26, rectangle.Perimeter);
            Assert.Equal(42, rectangle.Area);
        }

        [Fact]
        public void MaxDoubleSidesTest()
        {
            var rectangle = new Rectangle(double.MaxValue, double.MaxValue);
            Assert.Throws<ArgumentException>(() => rectangle.Perimeter);
            Assert.Throws<ArgumentException>(() => rectangle.Area);
        }

        [Fact]
        public void NegativeSidesTest()
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(-6, 7));
            Assert.Throws<ArgumentException>(() => new Rectangle(6, -7));
        }

        [Fact]
        public void SideSettesTest()
        {
            var rectangle = new Rectangle(6, 7);
            Assert.Throws<ArgumentException>(() => rectangle.A = -7);
            Assert.Throws<ArgumentException>(() => rectangle.B = -7);
        }
    }
}
