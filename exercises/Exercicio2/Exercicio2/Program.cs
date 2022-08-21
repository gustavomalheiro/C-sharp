using System;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {

            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retangulo: ");
            r.largura = double.Parse(Console.ReadLine());
            r.altura = double.Parse(Console.ReadLine());

            Console.WriteLine(r);
        }
    }
}
