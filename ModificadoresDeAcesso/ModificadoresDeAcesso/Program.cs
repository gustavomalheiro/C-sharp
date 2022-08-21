using System;
/*
 * public - propria classe, subclasses no assembly, classes do assembly, subclasses fora do assembly, classes fora do assembly
 * protected internal - propria classe, subclasses no assembly, classes do assembly, subclasses fora do assembly
 * internal - propria classe, subclasses no assembly, classes do assembly
 * protected - propria classe, subclasses no assembly, subclasses fora do assembly
 * private protected - propria classe, subclasses no assembly
 * private - propria classe
 * 
 * nota: assembly, como ja vimos, e o mesmo projeto. Lembrando que uma solucao pode ter varios projetos
 * 
 * MODIFICADORES DE ACESSO PARA A CLASSE EM SI:
 * 
 * - Acesso por qualquer classe
 *  - public class Product
 * 
 * - Acesso somente dentro do assembly
 *  - internal class Product
 *  - class Product
 *  
 * - Acesso somente pela classe-mae
 *  - private class Product
 *  - Nota: classe aninhada, por padrao, e private
 * 
 *  
 *
 */
namespace ModificadoresDeAcesso {
    class Program {
        static void Main(string[] args) {

        }
    }
}
