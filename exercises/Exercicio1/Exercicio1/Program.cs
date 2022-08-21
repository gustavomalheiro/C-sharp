using System;
/*
 * 
 * Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
 * 
 * 
*/
namespace Exercicio1 {
    class Program {
        static void Main(string[] args) {

            Pessoa primeiraPessoa, segundaPessoa;
            string maisVelho;

            // instanciando os objetos a partir da classe Pessoa
            primeiraPessoa = new Pessoa();
            segundaPessoa = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            primeiraPessoa.nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeiraPessoa.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            segundaPessoa.nome = Console.ReadLine();
            Console.Write("Idade: ");
            segundaPessoa.idade = int.Parse(Console.ReadLine());

            if (primeiraPessoa.idade > segundaPessoa.idade) 
                maisVelho = primeiraPessoa.nome;
            else {
                maisVelho = segundaPessoa.nome;
            }
            
            Console.WriteLine($"Pessoa mais velha: {maisVelho}"); 
        }
    }
}
