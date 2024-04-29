using FigureLibrary.Figures.Interfaces;

namespace FigureLibrary.Figures
{
    public class Rectangle : IFigure
    {
        public Rectangle(double a, double b) 
        {
            CheckRectangle(a, b);

            _a = a; 
            _b = b;            
        }

        private double _a;
        public double A 
        { 
            get => _a;
            set
            {
                CheckRectangle(value, B);

                _a = value;
            }
        }

        private double _b;
        public double B
        {
            get => _b;
            set
            {
                CheckRectangle(A, value);

                _b = value;
            }
        }

        public double Perimeter
        {
            get
            {
                var perimeter = 2 * (A + B);

                if (double.IsPositiveInfinity(perimeter))
                    throw new ArgumentException("Переполнение типа double");

                return perimeter;
            }
        }

        public double Area
        {
            get
            {
                var area = A * B;

                if (double.IsPositiveInfinity(area))
                    throw new ArgumentException("Переполнение типа double");

                return area;
            }
        }

        private void CheckRectangle(double a, double b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentException("Стороны прямоугольника должны быть больше либо равны нулю");
        }
    }
}
