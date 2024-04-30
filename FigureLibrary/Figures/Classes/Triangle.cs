using FigureLibrary.Figures.Interfaces;

namespace FigureLibrary.Figures
{
    public class Triangle : IFigure
    {
        public Triangle(double a, double b, double c) 
        {
            CheckTriangle(a, b, c);

            _a = a; 
            _b = b; 
            _c = c;          
        }

        private double _a;
        public double A 
        { 
            get => _a;
            set
            {
                CheckTriangle(value, B, C);

                _a = value;
            }
        }
        private double _b;
        public double B
        {
            get => _b;
            set
            {
                CheckTriangle(A, value, C);

                _b = value;
            }
        }

        private double _c;
        public double C
        {
            get => _c;
            set
            {
                CheckTriangle(A, B, value);

                _c = value;
            }
        }

        public double Perimeter
        {
            get
            {
                var perimeter = (A + B + C) / 2;

                if (double.IsPositiveInfinity(perimeter))
                    throw new ArgumentException("Переполнение типа double");

                return perimeter;
            }
        }

        public double Area
        {
            get
            {
                var p = Perimeter;
                var area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

                if (double.IsPositiveInfinity(area))
                    throw new ArgumentException("Переполнение типа double");

                return area;
            }
        }

        public bool IsTriangleRight
        {
            get
            {
                var sqrA = Math.Pow(A, 2);
                var sqrB = Math.Pow(B, 2);
                var sqrC = Math.Pow(C, 2);

                if (double.IsPositiveInfinity(sqrA)
                    || double.IsPositiveInfinity(sqrB)
                    || double.IsPositiveInfinity(sqrC))
                    throw new ArgumentException("Переполнение типа double");

                return sqrA == sqrB + sqrC
                    || sqrB == sqrA + sqrC
                    || sqrC == sqrA + sqrB;
            }
        }

        private void CheckTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Все стороны треугольника должны быть больше нуля");

            if (double.IsPositiveInfinity(a + b) || double.IsPositiveInfinity(a + c) || double.IsPositiveInfinity(b + c))
                throw new ArgumentException("Переполнение типа double");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Сумма двух сторон треугольника должна быть больше третьей стороны");
        }
    }
}
