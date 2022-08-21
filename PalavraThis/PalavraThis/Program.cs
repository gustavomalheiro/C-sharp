using System;
/*
 * Palavra this
 * 
 * - E uma referencia para o proprio objeto
 * 
 * - Usos comuns:
 *  - Diferenciar atributos de variaveis locais (Java)
 *  - Referenciar outro construtor em um construtor 
 *  - Passar o proprio objeto como argumento na chamada de um metodo ou construtor
 * 
 */

namespace PalavraThis {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco);

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
