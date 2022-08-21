using System;
/*
 
  
 */
namespace ComOOPMetodos {
    class Program {
        static void Main(string[] args) {
            Triangulo x, y;

            x = new Triangulo(); // Objeto x do tipo Triangulo
            y = new Triangulo(); // Objeto y do tipo Triangulo


            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            // nem e necessario passar parametros, pois tudo ja consta no proprio objeto
            double areaX = x.Area();

            double areaY = y.Area();

            Console.Write($"Area de X = {areaX.ToString("F4")}");

            Console.WriteLine("");

            Console.Write($"Area de Y = {areaY.ToString("F4")}");

            Console.WriteLine("");

            Console.Write($"Maior area = {MaiorArea(areaX, areaY)}");

        }

        static char MaiorArea(double x, double y) {
            if (x > y)
                return 'X';

            return 'Y';
        }
    }
}
