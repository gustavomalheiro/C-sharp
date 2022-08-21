
namespace Encapsulamento {
    class Produto {
        // vamos fazer o encapsulamento dessa classe para impedir que ela exponha a integridade
        // do nosso produto. Tudo sendo public permite que o programador livremente altere as propriedades
        // por padrao no C#, quando vamos trabalhar com atributos privativos, comeca com _ e letra minuscula
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // agora preciso de alguma forma, disponibilizar esses atributos para o meu programa
        // se nao nao consigo nem exibir na tela

        public string GetNome() {
            return _nome;
        }

        // void pois nao retorna nada como saida
        public void SetNome(string nome) {
            // ira manter o valor antigo caso: o nome seja vazio ou menor que 1 caractere
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }

        public double GetPreco() {
            return _preco;
        }

        // como eu nao quero que quantidade seja alterada de forma alguma a nao ser
        // pelo metodo adicionar e remover produtos, eu n vou implementar o metodo set.
        // so o get
        public int GetQuantidade() {
            return _quantidade;
        }


        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + _preco.ToString("F2")
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
