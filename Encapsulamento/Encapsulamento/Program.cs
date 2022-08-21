using System;

/*
 * ENCAPSULAMENTO
 * 
 * - E um principio que consiste em esconder detalhes de implementacao
 *  de um componente, expondo apenas operacoes seguras e que o mantenha
 *  em um estado consistente. Analogia: radio.
 *  
 *  - Regra de ouro: o objeto deve sempre estar em um estado consistente, e a
 *  propria classe deve garantir isso.
 *  
 *  OPCAO 1: Implementacao manual
 *  
 *  - Todo atributo e definido como private
 *  
 *  - Implementa-se metodos Get e Set para cada atributo, conforme regras de negocio.
 *  
 *  - Nota: nao e usual na plataforma C#
 *  
 *  QUAIS AS VANTAGENS?
 *  
 *  Alem da protecao, voce pode incluir logicas nos metodos. 
 *  Como por exemplo, nao aceitar nomes vazios ou com outro caractere ou menos
 * 
 */
namespace Encapsulamento {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);

            // com os atributos em public, isso e totalmente permitido
            // porem eu so quero que o produto seja alterado pelos metodos
            // adicionar produto e remover produto
            // assim que mudamos para private, ja mostra que e inacessivel devido
            // ao nivel de protecao.
            // p.Quantidade = -10;

            Console.WriteLine(p.GetNome());

            p.SetNome("TV 4K");

            // imprimindo apos alterar
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());

            // nao existem
            // p.SetPreco();
            // p.SetQuantidade();
        }
    }
}
