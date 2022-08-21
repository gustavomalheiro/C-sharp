using System;

namespace EntradaDados1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.ReadLine();
            // vai ler da entrada padrao ate a quebra de linha
            // retorna em forma de String

            /*
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            */

            // Ler 3 palavras, uma em cada linha, armazenando cada uma em uma variavel
            /*
            Console.WriteLine("Voce digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            */

            // ler tres palavras na mesma linha, separadas por espaco, armazenando cada uma em uma variavel
            // comando split

            // lendo normalmente a variavel
            //string s = Console.ReadLine();

            // vetor = estrutura com varios dados
            // split reconhece cada pedaco separado por um espaco em branco
            // cada uma delas sendo armazenada em uma posicao do vetor de string
            //string[] v = s.Split(' ');

            // forma a fazer sem precisar declarar a primeira string
            string[] v = Console.ReadLine().Split(' ');

            // colocando cada posicao do vetor em uma variavel
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
