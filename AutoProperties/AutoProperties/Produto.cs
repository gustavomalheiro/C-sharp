/*
 * PROPRIEDADES AUTOIMPLEMENTADAS
 * 
 * - E uma forma simplificada de se declarar propriedades que nao necessitam logicas 
 * particulares para as operacoes get e set. Como por exemplo o nome. Ele no caso, 
 * nao poderia ser feito com auto properties
 * 
 * 
 */
namespace AutoProperties {
    class Produto {

        // no caso do nome, ele tem uma logica particular,
        private string _nome;
        // eu devo colocar o atributo como public e na frente do set, colocar private
        // sinalizando que ele nao pode ser alterado por outros arquivos
        // atalho pra isso prop + tabx2 -> monta a estrutura
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
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
            return _nome
            + ", $ "
            + Preco.ToString("F2")
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
