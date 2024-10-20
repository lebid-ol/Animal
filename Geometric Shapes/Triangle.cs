using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_Shapes
{
    internal class Triangle
    {
        internal double SideA { get; set; }
        internal double SideB { get; set; }
        internal double SideC { get; set; }

        internal Triangle(double sideA, double sideB, double sideC)
        {

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        internal double CalculateArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        internal double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
}
}
