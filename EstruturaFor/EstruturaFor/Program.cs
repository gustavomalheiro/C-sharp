using System;

namespace EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            // usada geralmente quando vc conhece o numero de repeticoes
            // quando nao, usar o while
            int total = 0;

            Console.Write("Quantos numeros inteiros voce vai digitar? ");
            int x = int.Parse(Console.ReadLine());

            for (int y = 0; y < x; y++) {
                Console.Write($"Valor #{y + 1}: "); // saida de dados com interpolacao
                int valor = int.Parse(Console.ReadLine());
                // nao tem problema descartar valor apos a execucao do for

                total += valor;
            }

            Console.Write("Soma = " + total);


        }
    }
}
