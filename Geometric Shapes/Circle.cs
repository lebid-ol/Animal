using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_Shapes
{
    internal class Circle : Program.Shape
    {
        internal double Radius { get; set; }

        internal Circle(double radius) {

            Radius = radius;      
        }

        internal  double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        internal double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

    }

}
