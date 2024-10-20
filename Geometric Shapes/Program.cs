namespace Geometric_Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle MyCircle = new Circle(4.0);
            Console.WriteLine($"Площадь круга c радиусом {MyCircle.Radius} составляет {MyCircle.CalculateArea()}, длина окружности круга составляет {MyCircle.CalculatePerimeter()}");

            Rectangle MyRectangle = new Rectangle(6.5, 8);
            Console.WriteLine($"Площадь прямоугольника c высотой {MyRectangle.Width} и шириной {MyRectangle.Length} составляет {MyRectangle.CalculateArea()}, периметр составляет {MyRectangle.CalculatePerimeter()}");

            Triangle MyTriangle = new Triangle(6, 8, 7);
            Console.WriteLine($"Площадь треуголника cо сторонами {MyTriangle.SideA}, {MyTriangle.SideB}, {MyTriangle.SideC} составляет {MyTriangle.CalculateArea()}, периметр составляет {MyTriangle.CalculatePerimeter()}");
        }

        public class Shape
        {

            public double CalculateArea()
            {
                return 0.0;
            }

            public  double CalculatePerimeter()
            {
                return 0.0;
            }
        }
    }
}
