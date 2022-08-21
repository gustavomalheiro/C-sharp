using System;

namespace ProgramAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            a += 10;
            Console.WriteLine(a);
            a -= 2; // recebe oq ja tinha em a -2
            Console.WriteLine(a);
            a *= 2;
            Console.WriteLine(a);
            a /= 2;
            Console.WriteLine(a);
            a %= 2;
            Console.WriteLine(a);

            a = 10;

            // funcionam com strings:
            string s = "ABC";
            s += "DEF";
            Console.WriteLine(s); // concatena

            // operador aritmetico / atribuicao
            a++; // incrementar 1 em uma variável
            ++a;
            a--; // decrementar 1 em uma variável
            --a;

            // uma pequena diferença entre os sinais antes e depois, mas só vai diferença quando atribuimos para outra variavel

            int b = a++;
            Console.WriteLine(a);
            Console.WriteLine(b); // b vai estar valendo 10, pois primeiro ele atribui ao b e depois incrementa

            int c = ++a;
            Console.WriteLine(a);
            Console.WriteLine(c); // c vai estar valendo 12, pois primeiro ele incremente e depois atribui
        }
    }
}
