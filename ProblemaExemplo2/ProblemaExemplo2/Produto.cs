/*
 * O que vem a ser esse tal de ToString?
 * 
 * - Toda a classe em C# e uma subclasse da classe Object (ela e herdeira de Object)
 * - Nossa classe Produto e um Object tambem, assim como nossa classe Triangulo
 * 
 * - Object possui os seguintes metodos
 *  - GetType - retorna o tipo do objeto
 *  - Equals - compara se o objeto e igual ao outro
 *  - GetHashCode - retorna um codigo hash do objeto
 *  - ToString - converte o objeto para string (o que veremos agora)
 *   - Entao se voce dentro de sua classe implementar o metodo toString,
 *     tera condicoes de definir como esse objeto e representado na forma de string
 *  
 * 
 * 
 * 
 */
namespace ProblemaExemplo2 {
    class Produto {

        // atributos
        public string Nome;
        public double Preco;
        public int Quantidade;

        // metodos
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        // essa funcao pode ser void pois ela nao precisa retornar um valor de saida
        // ela vai simplesmente la na caixinha quantidade do objeto e adicionar valores la
        public void AdicionarProdutos(int qtdItem) {
            Quantidade += qtdItem;
        }

        public void RemoverProdutos(int qtdItem) {
            Quantidade -= qtdItem;
        }
        
        // toString que vem herdado da classe Object (necessario sobreposicao (override))
        // agora sempre que chamarmos um objeto em um writeline ele implicitamente vai chamar
        // o metodo ToString e vai fazer essa conversao para gente
        public override string ToString() {
            return Nome
                + ", $ "
                + Preco.ToString("F2") // perceba que o ToString tambem tem no Preco, pois tambem deriva de um Object
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2");
        }


    }
}
