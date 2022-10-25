using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Figure
    {
        private Point[] points;
        private string name;
        public Figure(Point[] points) {
            if (points.Length < 3 && points.Length > 5) {
                throw new AggregateException("Поза діапазоном");

            }

            name = Enum.GetName(typeof(Polygon), points.Length);
            this.points = points;
        }

        public float LengthSide(Point A, Point B) {
            return MathF.Sqrt(MathF.Pow(B.X - A.X, 2) + MathF.Pow(B.Y - A.Y, 2));

        }

public void PerimeterCalculator() {
    float perimeter = 0;
    for (int i = 0; i < points.Length - 1; i++) {
        perimeter += LengthSide(points[i], points[i+1]);
    }

    perimeter += LengthSide(points[points.Length - 1], points[0]);

    Console.WriteLine($"Назва: {name}");
    Console.WriteLine($"Периметр: {perimeter}");
}

    }
}