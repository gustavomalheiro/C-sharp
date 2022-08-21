using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int x = 10;

             Console.WriteLine("Bom dia");

             // estrutura condicional simples
             if (x > 5) {
                 Console.WriteLine("Boa tarde");
             }

             Console.WriteLine("Boa noite");*/

            /*// estrutura condicional composta
            Console.WriteLine("Entre com um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                // se a condicao a cima for verdadeira
                Console.WriteLine("Par!");
            } 
            else {
                // se a condicao for falsa
                Console.WriteLine("Impar!");
            }
*/
            // encadeamentos de estruturas condicionais
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom dia!");
            } 
            else if (hora < 18) {
                Console.WriteLine("Boa tarde!");
            }
            else {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
