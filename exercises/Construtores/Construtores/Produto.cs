using System;
using System.Collections.Generic;
using System.Text;

namespace Construtores {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // criando o construtor personalziado
        // agora, sempre que formos instanciar um objeto dessa classe, o compilador
        // exigira esses tres valores
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return Nome
            + ", $ "
            + Preco.ToString("F2")
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
