using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle

{
class Program {
    static void Main(string[] args) {
        rectangle Rectangle = new rectangle(8, 3);
        Console.WriteLine($"Area: {Rectangle.Area}");
        Console.WriteLine($"Perimeter: {Rectangle.Perimeter}");
    }
}
}