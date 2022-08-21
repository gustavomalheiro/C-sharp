using System;

namespace ProblemaExemplo2 {
    class Program {
        static void Main(string[] args) {

            int qtdItem;

            // sim, pode fazer a instanciacao na mesma linha da declaracao '--
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            // se em lugar nenhum do programa eu definir como devera ser impresso
            // o objeto, o C# automaticamente imprime namespace.classe
            // so para deixar claro, seria possivel resolver o problema aqui no
            // programa principal, porem toda vez que fossemos imprimir um produt
            // teriamos que repetir todo o codigo
            Console.WriteLine($"Dados do produto: {p}");

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            qtdItem = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qtdItem);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qtdItem = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qtdItem);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");

        }
    }
}
