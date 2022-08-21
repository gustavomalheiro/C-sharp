using System;

namespace Exercicio4 {
    class Program {
        static void Main(string[] args) {

            Aluno a = new Aluno();

            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as tres notas do aluno: ");
            a.N1 = double.Parse(Console.ReadLine());
            a.N2 = double.Parse(Console.ReadLine());
            a.N3 = double.Parse(Console.ReadLine());

            Console.WriteLine(a);
        }
    }
}
