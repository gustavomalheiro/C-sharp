namespace SintaxeAlternativaInicializacao {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

       /* public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }*/

        // Construtor alternativo opcional que cria produtos com nome, preco e 0 quantidade (fixo) (sobrecarga)
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            // atribuir 0 a quantidade nao e necessario, pois por padrao todos os valores numericos comecam valendo 0
            Quantidade = 0;
        }

        public Produto() {
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
