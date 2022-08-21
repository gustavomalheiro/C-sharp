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
 * 
 */

namespace MembrosEstaticos {
    class Program {

        // esse valor tambem sera estatico, pois sera utilizado em uma operacao estatica
        // caso tiremos o static, o compilador vai exigir o static, pois estou usando dentro
        // de uma operacao estatica
        static double Pi = 3.14;

        static void Main(string[] args) {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2"));
        }

        // deve ser estatica pois nao podemos chamar uma funcao que nao e estatica
        // dentro de uma funcao estatica. 
        static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }

        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(3, r);
        }
    }
}
