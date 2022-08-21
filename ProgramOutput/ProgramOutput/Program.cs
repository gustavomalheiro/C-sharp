using System;
using System.Globalization;

namespace ProgramOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.12413;
            string nome = "Maria";

            Console.Write("Bom dia!"); // sem o line, a linha não quebra
            Console.WriteLine("Boa tarde!"); 
            Console.WriteLine("Boa noite!");
            Console.WriteLine("--------IMPRIMINDO VARIÁVEIS-----------");
            Console.WriteLine(genero); 
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F4")); // para imprimir controlando a quantidade de casas decimais: .ToString("F2")
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); // duas casas decimais + formatação com o ponto
            Console.WriteLine(nome);

            // placeholders, concatenação e interpolação

            //placeholders (um lugar para entrar a variável)
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);

            //interpolação (versão 6 do c# em diante)
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais.");

            // concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");

        }
    }
}
