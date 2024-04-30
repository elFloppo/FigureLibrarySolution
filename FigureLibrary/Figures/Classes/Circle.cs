using FigureLibrary.Figures.Interfaces;

namespace FigureLibrary.Figures
{
    public class Circle : IFigure
    {
        public Circle(double radius) 
        {
            CheckCircle(radius);

            _radius = radius;        
        }

        private double _radius;
        public double Radius 
        { 
            get => _radius;
            set
            {
                CheckCircle(value);

                _radius = value;
            }
        }

        public double Perimeter
        {
            get
            {
                var perimeter = 2 * Math.PI * Radius;

                if (double.IsPositiveInfinity(perimeter))
                    throw new ArgumentException("Переполнение типа double");

                return perimeter;
            }
        }
            
        public double Area    
        {
            get
            {
                var area = Math.PI * Math.Pow(Radius, 2);

                if (double.IsPositiveInfinity(area))
                    throw new ArgumentException("Переполнение типа double");

                return area;
            }
        }

        private void CheckCircle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше нуля");
        }
    }
}
