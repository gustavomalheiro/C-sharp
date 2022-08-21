using System;

namespace ExercicioEntradaSaidaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int room = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preco de um produto: ");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha): ");
            string[] v = Console.ReadLine().Split(' ');

            string lastName = v[0];
            int age = int.Parse(v[1]);
            double height = double.Parse(v[2]);

            Console.WriteLine(" ");

            Console.WriteLine(name);
            Console.WriteLine(room);
            Console.WriteLine(price);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height);





        }
    }
}
