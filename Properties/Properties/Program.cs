using System;

namespace Properties {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);

            // com os atributos em public, isso e totalmente permitido
            // porem eu so quero que o produto seja alterado pelos metodos
            // adicionar produto e remover produto
            // assim que mudamos para private, ja mostra que e inacessivel devido
            // ao nivel de protecao.
            // p.Quantidade = -10; -> tbm na funciona

            Console.WriteLine(p.Nome);

            // ele continua respeitando a logica implementada para impedir que seja colocado
            // nomes de apenas 1 caractere
            p.Nome = "TV 4K";

            // vale ressaltar que ainda nao e permito atribuir valores a atributos que vc nao definiu o set
            // nas properties
            // p.Preco = 100.0; -> n funcion

            // imprimindo apos alterar
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

            // nao existem
            // p.SetPreco();
            // p.SetQuantidade();
        }
    }
}
