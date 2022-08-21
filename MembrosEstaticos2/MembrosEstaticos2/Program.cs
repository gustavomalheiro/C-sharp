using System;
/*
 * Membros estaticos
 * 
 * - Tambem chamados de membros de classe (metodo de classe, atributo de classe)
 *  - Em oposicao a membros de instancia (tudo que vimos ate agora)
 *  
 *  - Sao membros que fazem sentido independentemente de objetos. Nao precisam de objeto
 *  para serem chamados. Sao chamados a partir do proprio nome da classe.
 *  
 *  - Aplicacao comuns:
 *   - Classes utilitarias -> Math.sqrt(double) eu nao preciso instanciar o Math para depois chamar o Math.sqrt
 *   Math e uma definicao de uma classe. A partir do nome da classe eu chamo o Sqrt.
 *   - Declaracao de constantes
 *  
 *  - Uma classe que possui somente membros estaticos, pode ser uma classe estatica tambem.
 *    Esta classe nao podera ser instanciada.
 *    
 *    Lembra da operacao Area do exercicio do triangulo? 
 *    ela nao pode ser estatica, pois cada instancia tem um resultado diferente.
 *    uma operacao estatica sempre vai dar o mesmo resultado independente de objeto
 *    
 *    So parar esclarescer:
 *    Voce poderia sim fazer uma calculadora com a funcao Area do triangulo e transformar 
 *    em estatico, tambem e uma solucao. Mas por motivos de coesao, e melhor deixar que a 
 *    propria classe cuide disso. Sendo assim, a calculadora so cuidara de operacoes mais
 *    genericas.
 * 
 * 
 */

namespace MembrosEstaticos2 {
    class Program {

        static void Main(string[] args) {


            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2"));
        }
    }
}
