/*
 * Get e Set nao serao mais necessarios
 * 
 * PROPRIEDADES
 * 
 * - Sao definicoes de metodos encapsulados, porem expondo uma sintaxe
 * familiar a de atributios e nao de metodos
 * 
 * - Uma propriedade e um membro que oferece um mecanismo flexiviel para ler, gravar ou
 * calcular o valor de um campo particular. As propriedades podem ser usadas como se fossem
 * atributos publicos, mas na verdade elas sao metodos especiais chamados "acessadores".
 * Isso permite que os dados sejam acessados facilmente e ainda ajuda a promover a seguranca
 * e a flexibilidade dos metodos
 * Ou seja: uma sintaxe de atributos, porem a seguranca dos metodos
 * 
 * Entao, ele continua respeitando todo o encapsulamento, porem com o nome original parecendo
 * um atributo :) bem mais elegante
 * 
 */

namespace Properties {
    class Produto {

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

        // nos temos entao o nome privativo encapsulado, porem vamos expor para 
        // o mundo externo o Nome com N maiusculo, uma fantasia para o _nome em
        // forma de property
        // agora dentro da propriedade posso juntar o get e o set
        // ao inves de usar o nome minusculo para representar o que recebemos da chamada
        // utilizaremos o value
        // dessa forma, get e set n sao mais necessarios
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        // mantem o padrao de nao colocar set nesses atributos, porem mais elegante com properties
        public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
            get { return _quantidade; }
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
