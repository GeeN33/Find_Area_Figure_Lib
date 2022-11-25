using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Area_Figure_Lib
{
    public static class Find_Area_Figure
    {
        // вычислить площадь треугольника
        public static double find_area(double radius)
        {
            Console.WriteLine("Площадь круга");
            return Math.PI * Math.Pow(radius, 2);
        }
        // вычислить площадь круга
        public static double find_area(double a, double b, double c)
        {
            if (a * a + b * b == c * c)
            {
                Console.WriteLine("Этот треугольник прямоугольный");
                Console.WriteLine("Площадь треугольника");
                return (a * b) / 2;
            }
            else if (a * a + c * c == b * b)
            {
                Console.WriteLine("Этот треугольник прямоугольный");
                Console.WriteLine("Площадь треугольника");
                return (a * c) / 2;
            }
            else if (c * c + b * b == a * a)
            {
                Console.WriteLine("Этот треугольник прямоугольный");
                Console.WriteLine("Площадь треугольника");
                return (c * b) / 2;
            }
            else
            {
                Console.WriteLine("Этот треугольник не прямоугольный");
                Console.WriteLine("Площадь треугольника");
                return (a + b + c) / 2;
            }



        }
    }
}
