using System;

/*
 * Construtor
 * 
 * - E uma operacao especial da classe, que executa no momento da instanciacao do objeto (quando vc da o comandinho new)
 * 
 * - Usos comuns:
 *  - Iniciar valores dos atributos
 *  - Permitir ou obrigar que o objeto receba dados / dependencias 
 *  no momento de sua instanciacao (injecao de dependencia)
 *  
 *  - Se um construtor customizado nao for especificado, a classe disponibiliza o construtor
 *  padrao:
 *    - Produto p = new Produto(); -> nao recebe nenhum parametro de entrada
 *  
 *  - E possivel especificar mais de um construtor na mesma classe (sobrecarga)
 *  
 *  Proposta de melhoria
 *  
 *  Quando executamos o comando abaixo, instanciamos um produto "p" com seus atributos "vazios":
 *  
 *  p = new Produto(); -> se nao adicionarmos nada, vai ficar tudo nulo/zero
 *  
 *  Entretando, faz sentido um produto quie nao tem nome? Faz sentido um produto que nao tem preco?
 *  
 *  Com o intuito de evitar a existencia de produtos sem nome e sem preco, e possivel fazer com que
 *  seja "obrigatoria" a iniciacao desses valores?
 *  Sim! Com os construtores customizados, o programador pode colocar atributos que sempre devem ter valores
 *  como preco e nome de produto
 */

namespace Construtores {
    class Program {
        static void Main(string[] args) {
  
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            // agora a instanciacao sera feita apos ja termos coletado os dados necessarios
            // entao termos que armazena-las em variaveis auxiliares para que apos coletar todos
            // passemos elas nos parametros do construtor
            Produto p = new Produto(nome, preco, quantidade);

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
