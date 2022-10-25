using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle

{
public class rectangle {
    private float side1;
    private float side2;

    public float Area{ 
        get{
             return AreaCalculator();
    }}
    public float Perimeter {
        get {
            return PerimeterCalculator();
        }
    }
    public rectangle(float side_1, float side_2) {
side1 = side_1;
side2 = side_2;
    }
private float AreaCalculator() {
    return side1 * side2;
}
private float PerimeterCalculator() {
    return (side1 + side2) * 2;
}
}    
}