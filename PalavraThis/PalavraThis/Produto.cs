
namespace PalavraThis {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() {
            Quantidade = 10;
        }

        // Construtor alternativo opcional que cria produtos com nome, preco e 0 quantidade (fixo) (sobrecarga)
        public Produto(string nome, double preco) : this() {
            Nome = nome;
            Preco = preco;
        }

        // forma mais otimizada de fazer um construtor quando temos um construtor anterior
        // com codigo ja utilizado
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
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
