using System;

namespace SemOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            double aX, bX, cX, aY, bY, cY;

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            aX = double.Parse(Console.ReadLine());
            bX = double.Parse(Console.ReadLine());
            cX = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            aY = double.Parse(Console.ReadLine());
            bY = double.Parse(Console.ReadLine());
            cY = double.Parse(Console.ReadLine());

            double areaX = AreaTriangulo(aX, bX, cX);

            double areaY = AreaTriangulo(aY, bY, cY);

            Console.Write($"Area de X = {areaX.ToString("F4")}");

            Console.WriteLine("");

            Console.Write($"Area de Y = {areaY.ToString("F4")}");

            Console.WriteLine("");

            Console.Write($"Maior area = {MaiorArea(areaX, areaY)}");

        }

        static double AreaTriangulo(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }

        static char MaiorArea(double x, double y)
        {
            if (x > y) 
                return 'X';

            return 'Y';
        }
    }
}
