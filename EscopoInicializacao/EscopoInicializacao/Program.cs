using System;

namespace EscopoInicializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // nao e possivel utilizar uma variavel que nao foi iniciada
            int x = 0;

            Console.WriteLine(x);

            // escopo
            // uma variavel declarada dentro de um bloco vai sumir caso ele termine
            // escopo maior = programa principal
            // escopo menor = qualquer programa dentro dele
            // para evitar esse problema, declare a variavel no escopo principal
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0; // sempre necessario atribuir

            if (preco > 100.00) {
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
            // funcionou sem problemas =D
        }
    }
}
