using System;

namespace ComOOPMetodos {
    class Triangulo {
        /*
         * Com o uso da CLASSE, agora nos temos uma variavel
         * composta do tipo "Triangulo" para representar cada triangulo:
         * 
         * Triangulo x, y;
         * x = new Triangulo();
         * y = new Triangulo();
         * 
         * Agora vamos melhorar nossa CLASSE, acrescentando nela um METODO para
         * calcular a area.
         * 
         * - perceba que anteriormente temos uma repeticao de codigo no calculo da area
         * - a logica toda de calcular a area do triangulo deve estar dentro da propria classe
         * triangulo. Deveria ser delegada para a classe triangulo. E e isso que iremos fazer agora,
         * delegar o calculo da area para a classe Triangulo.
         */

        public double A;
        public double B;
        public double C;

        // public para o metodo ser acessado em outros arquivos
        // tipo do metodo double pois retorna double
        // essa funcao Area nao ira precisar de nenhum dado de entrada, pois ela pertence
        // a classe Triangulo onde ja temos A, B e C que tambem pertencem a classe triangulo
        // uma funcao dentro da propria classe
        public double Area() {
            // nao e necessario especificar qual triangulo estamos mexendo, pois dentro da classe
            // estamos tratando triangulo no geral
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
}
