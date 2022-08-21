using System;
/*
  Triangulo e uma entidade com 3 atributos: a, b, c.
 
  Estamos usando 3 variaveis distintas para representar cada triangulo

  double xA, xB, xC, yA, yB, yC -> 6 espacos alocados na memoria

  para melhorar isso, vamos usar uma CLASSE para representar um triangulo.

  CLASSE
  - E um tipo estruturado que pode conter (membros):
   - Atributos ( dados / campos )
   - Metodos ( funcoes / operacoes )

  - A classe tambem pode prover muitos outros recursos, tais como: 
   - construtores
   - sobrecarga
   - encapsulamento
   - heranca
   - polimorfismo
  
  - Exemplos:
   - Entidades: Produto, Cliente, Triangulo
   - Servicos: ProdutoService, ClienteService, EmailService, StorageService
   - Controladores: ProdutoController, ClienteController
   - Utilitarios: Calculadora, Compactador
   - Outros (views, repositorios, gerenciadores, etc.)

    - A partir de agora tudo em nossas aplicacoes serao representados por classes, pois 
    - a classe e o fundamento principal de OOP

    Nos tivemos uma aula importantissima, que e a parte mais primordial da OOP.
    - Aprendemos que a classe e a definicao do tipo
    - aprendemos tambem que Objetos: sao instancias da classe
  
 */
namespace ComOOP
{
    class Program
    {
        static void Main(string[] args)
        {
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

            double areaX = AreaTriangulo(x.A, x.B, x.C);

            double areaY = AreaTriangulo(y.A, y.B, y.C);

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
