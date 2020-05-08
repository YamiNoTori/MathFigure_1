using System;
using CalcAreaLib;

namespace MathFigureAreaLibView
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = 3;
            double[] Sides = new double[] { 5, 4, 1.2 };


            // Тест
            Console.WriteLine($"Площадь круга с радиусом {R} = {CalcCircle(R)}");
            Console.WriteLine($"Площадь треугольника со сторонами {Sides[0]}, {Sides[1]}, {Sides[2]} = {CalcTriangle(Sides)}");

        }

        static double CalcCircle(double r)
        {
            FigureController controller = new FigureController();
            controller.CreateCircle(r);
            return controller.Figure.CalcArea();
        }

        static double CalcTriangle(double[] sides)
        {
            FigureController controller = new FigureController();
            controller.CreateTriangle(sides);
            return controller.Figure.CalcArea();
        }
    }
}
