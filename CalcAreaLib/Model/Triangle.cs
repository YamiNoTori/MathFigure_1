using System;
namespace CalcAreaLib
{
    public class Triangle : IFigure
    {
        /// <summary>
        /// Стороны треугольника
        /// </summary>
        private double[] Sides { get; set; }


        public Triangle(double[] sides)
        {
            Sides = sides;
        }

        /// <summary>
        /// Переопределение метода вычисления площади
        /// </summary>
        /// <returns></returns>
        public double CalcArea()
        {
            // Вычисление полупериметра
            double p = .0f;
            for (int i = 0; i < Sides.Length; i++)
            {
                p += Sides[i];
            }
            p /= 2;

            double result = p;
            for (int i = 0; i < Sides.Length; i++)
            {
                result *= p - Sides[i];
            }


            return Math.Sqrt(result);
        }
    }
}
