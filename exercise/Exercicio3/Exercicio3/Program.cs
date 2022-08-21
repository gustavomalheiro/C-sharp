using System;

namespace Exercicio3 {
    class Program {
        static void Main(string[] args) {

            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salario bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"Funcionario: {f}");

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine());

            f.AumentarSalario(porcentagem);

            Console.WriteLine();

            Console.WriteLine($"Dados atualizados: {f}");
        }
    }
}
