using System;

namespace Funcoes
{
    class Program
    {   
        // o static void main tambem e uma funcao
        // funcao padrao do C# que indica o entry point da aplicacao
        static void Main(string[] args)
        {
            /*
             - Representam um processamento que possui um significado
                - Math.Sqrt(double)
                - Console.WriteLine(string)

            - Principais vantagens: modularizacao, delegacao e reaproveitamento

            - Dados de entrada e saida
                - Funcoes podem receber dados de entrada (parametros ou argumentos)
                - Funcoes podem ou nao retornar uma saida

            - Em orientacao a objetos, funcoes em classes recebem o nome de "metodos"
             */

            Console.WriteLine("Digite 3 numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);

        }

        // como meu entry point e uma funcao static, para uma funcao funcionar dentro dela, tem que ter static tbm
        // delegando a logica toda para uma funcao, minha main fica muito mais simples
        // composta por static / tipo de saida / nome da funcao
        // nao tem importancia o nome das variaveis do parametro, nao precisam combinar com os argumentos
        static int Maior(int n1, int n2, int n3) {

            int m;

            if (n1 > n2 && n1 > n3) {
                m = n1;
            }
            else if (n2 > n3) {
                m = n2;
            }
            else {
                m = n3;
            }

            return m;
        }
    }
}
