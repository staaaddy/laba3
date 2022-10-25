using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Program
    {
        static void Main(string[] args) {
            Point[] points = new Point[] {
                new Point(2, 4, "A"),
                new Point(-2, 0, "B"),
                new Point(3, 5, "C"),
                new Point(1, 3, "D"),
            };

            Figure figure = new Figure(points);
            figure.PerimeterCalculator();
        }
    }
}