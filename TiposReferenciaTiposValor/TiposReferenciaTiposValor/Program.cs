using System;
/*
 * CLASSES SAO TIPO REFERENCIA
 * 
 * Variaveis cujo tipo sao classes nao devem ser entendidas como caixas, mas sim
 * "tentaculos" (ponteiros) para caixas.
 * 
 * Product p1, p2; -> voce criou 2 variaveis na sua memoria na area stack
 * porem as caixinhas so vao ser criadas quando vc instancia-las.
 * Ai sim, na memoria, em uma outra area chamada Heap, voce estara instanciando
 * o objeto. Esse objeto vai ter um endereco de memoria e esse endereco de memoria
 * sera alocado na variavel p1, p2 criada em stack.
 * 
 * quando vc faz: p2 = p1, o p2 passa a apontar para onde o p1 aponta. Ele vai receber o mesmo
 * endereco armazenado em p1.
 *
 * VALOR "null"
 *
 * Tipos referencia aceitam o valor "null", que indica que a variavel aponta pra ninguem.
 * 
 * p2 = null; -> indica que p2 nao aponta para ninguem
 * 
 * STRUCTS SAO TIPO VALOR
 * 
 * A linguagem C-sharp possui tambem tipos valor, que sao os "structs". Structs sao CAIXAS e
 * nao ponteiros. 
 * 
 * Structs sao os tipos basicos da linguagem: double, int, string, etc.
 * 
 * double x, y;
 * 
 * x = 10;
 * 
 * y = x;
 * y nao estara recebendo o endereco para onde x aponta, ele vai receber uma copia de x
 * 
 *  por isso chamamos de tipo valor e nao referencia.
 *  
 *  outros structs importantes: DateTime, TimeSpan
 * 
 */

namespace TiposReferenciaTiposValor {
    class Program {
        static void Main(string[] args) {
            
        }
    }
}
