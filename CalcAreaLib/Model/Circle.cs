using System;

namespace CalcAreaLib
{
    public class Circle : IFigure
    {
        private double Radius { get; set; } 

        public Circle(double r)
        {
            Radius = r;
        }

        /// <summary>
        /// Переопределение метода вычисления площади
        /// </summary>
        /// <returns></returns>
        public double CalcArea()
        {
            return Math.PI * (Radius * Radius);
        }

    }
}
