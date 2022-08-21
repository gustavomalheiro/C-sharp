using System;

namespace ExercicioMembrosEstaticos {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual e a cotacao do dolar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dolares voce vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.ConverterDolar(cotacao, quantidade).ToString("F2")}");
        }
    }
}
