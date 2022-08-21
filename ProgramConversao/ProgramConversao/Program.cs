using System;

namespace ProgramConversao
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;

            // conversão implicita de float para double
            double y = x;

            Console.WriteLine(y);

            double a;
            int b;

            a = 5.1;
            // conversão explicita(casting), já que a implicita não é possível
            b = (int)a;

            // a variável b agora está valendo 5 redondo. Houve perda de informação.
            Console.WriteLine(b);

            int z = 5;
            int w = 2;

            double resultado = (double) z / w;
            
            // deveria mostrar 2.5 e não 2. Mas o compilador entendeu que você queria fazer uma expressão de z / w considerando apenas valores inteiros
            // para garantir que o resultado seja o double e não descarte as casas decimais, é necessário utilizar o casting na frente do z.
            // um double dividido por um inteiro, vai dar um double
            Console.WriteLine(resultado);
        }
    }
}
