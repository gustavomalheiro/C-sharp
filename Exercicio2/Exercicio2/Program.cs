using System;
/* 
 * Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.
 * 
 * 
 * 
 */

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {

            Funcionario f1, f2;
            double salarioMedio;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.salario = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.salario = double.Parse(Console.ReadLine());

            salarioMedio = (f1.salario + f2.salario) / 2;

            Console.WriteLine($"Salario medio = {salarioMedio.ToString("F2")}");

        }
    }
}
