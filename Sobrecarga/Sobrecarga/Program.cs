using System;
/*
 * Sobrecarga
 * 
 * - E um recurso que uma classe possui de oferecer mais de uma operacao com o mesmo nome,
 *   porem com diferentes listas de parametros.
 * - Isso e muito comum em orientacao a objetos, pois as vezes queremos diferentes comportamentos
 *   para a mesma operacao. O que vai variar entre elas e o numero de parametros.
 * 
 * PROPOSTA DE MELHORIA
 * 
 * - Vamos criar um construtor opcional, o qual recebe apenas nome e preco do produto. A quan
 *  tidade em estoque deste novo produto, por padrao, devera entao ser iniciada com o valor zero.
 *  
 *  Nota: e possivel tambem incluir um construtor padrao (sem parametros)
 *  Nota2: uma vez colocando um construtor personalizado, nao sera mais possivel instanciar pelo construtor vazio
 *  A menos que voce defina o construtor vazio tambem na classe
 */
namespace Sobrecarga {
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
