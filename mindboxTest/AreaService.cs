using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindboxTest
{
    public static class AreaService
    {
        public static double GetCircleArea(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус круга не может быть меньше нуля");
            double area = Math.PI * radius * radius;
            return area;
        }
        public static double GetRectangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA < 0)
                throw new ArgumentException("Сторона A не может быть меньше нуля");
            if (sideB < 0)
                throw new ArgumentException("Сторона B не может быть меньше нуля");
            if (sideC < 0)
                throw new ArgumentException("Сторона C не может быть меньше нуля");

            if (sideA + sideB < sideC)
                throw new ArgumentException("Данные стороны не могут образовывать треугольник");
            if (sideA + sideC < sideB)
                throw new ArgumentException("Данные стороны не могут образовывать треугольник");
            if (sideB + sideC < sideA)
                throw new ArgumentException("Данные стороны не могут образовывать треугольник");

            double area = 0;
            if (sideA * sideA + sideB * sideB == sideC * sideC)
            {
                area = sideA * sideB / 2;
                return area;
            }
            if (sideA * sideA + sideC * sideC == sideB * sideB)
            {
                area = sideA * sideC / 2;
                return area;
            }
            if (sideB * sideB + sideC * sideC == sideA * sideA)
            {
                area = sideB * sideC / 2;
                return area;
            }
            double p = (sideA + sideB + sideC) / 2;
            area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return area;
        }
    }
}
