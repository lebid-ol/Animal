using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_Shapes
{
    internal class Rectangle
    {
        internal double Length { get; set; }
        internal double Width { get; set; }

        internal Rectangle(double length, double width)
        {

            Length = length;
            Width = width;
        }

        internal double CalculateArea()
        {
            return Width * Length;
        }

        internal double CalculatePerimeter()
        {
            return 2 * (Width + Length);
        }
    }
}
