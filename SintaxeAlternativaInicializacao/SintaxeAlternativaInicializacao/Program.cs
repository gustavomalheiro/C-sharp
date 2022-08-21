using System;

/*
 * Existe uma Sintaxe especial em C-sharp para vc inicializar os objetos
 * mesmo que nao tenha construtores! Isso funciona mesmo se a classe nao possuir construtores implementados!
 * 
 * Produto p = new Produto {
 *      Nome = "TV",
 *      Preco = 900.0,
 *      Quantidade = 0
 * };
 * 
 * funciona com ou sem()
 * Produto p = new Produto() {
 *      Nome = "TV",
 *      Preco = 900.0,
 *      Quantidade = 0
 * };
 * 
 * Nota: se vc utilizar um construtor alternativo diferente do formato dessa inicializacao, 
 * ele nao vai liberar para construir, pois depende do construtor padrao da classe,
 * 
 * Nota: parece muito bom para testar programas
 * 
 */
namespace SintaxeAlternativaInicializacao {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco);

            // forma de inicializar objetos sem construtor (comentei esse construtor na classe Produto)
            Produto p3 = new Produto() { 
                Nome = "TV", 
                Preco = 500.00, 
                Quantidade = 20 
            };

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
