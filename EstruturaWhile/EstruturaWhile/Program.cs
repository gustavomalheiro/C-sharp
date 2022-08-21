using System;

namespace EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // regra:
            // V: executa e volta
            // F: pula fora

            Console.Write("Digite um numero: "); // sem o line para ficar lado a lado
            double x = double.Parse(Console.ReadLine());

            // enqunato o x for maior que zero, o loop continua
            while (x >= 0.0) {
               
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3"));

                Console.Write("Digite outro numero: ");
                x = double.Parse(Console.ReadLine());
            }

            // saiu do loop pois a condicao e falsa
            Console.WriteLine("Numero negativo!");
        }
    }
}
