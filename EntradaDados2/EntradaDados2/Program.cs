using System;

namespace EntradaDados2
{
    class Program
    {
        static void Main(string[] args)
        {
            // n pode converter string para inteiro, char, double. Necessario conversao manual de tipos
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double db = double.Parse(Console.ReadLine());

            // lendo varios dados na mesma linha
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);

            Console.WriteLine("Voce digitou: ");
            // e necessario colocar um numero e n um char ou string, se n quebra
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(db);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

        }
    }
}
