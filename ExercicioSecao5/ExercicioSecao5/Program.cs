using System;

namespace ExercicioSecao5 {
    class Program {
        static void Main(string[] args) {

            double valor;
            ContaBancaria c1;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)? ");
            char r = char.Parse(Console.ReadLine());

            if (r == 'n') {
                c1 = new ContaBancaria(numero, titular);
            } else {
                Console.Write("Entre o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());

                c1 = new ContaBancaria(numero, titular, depositoInicial);
            }

            

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c1);

            Console.WriteLine();
            Console.Write("Entre um valor para deposito: ");
            valor = double.Parse(Console.ReadLine());
            c1.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            c1.Saque(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c1);














           



        }
    }
}
