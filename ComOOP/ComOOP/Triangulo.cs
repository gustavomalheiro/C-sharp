namespace ComOOP { 
    class Triangulo
    {
        /*
         * public significa que esses atributos poderao ser acessados
        // em outro arquivo
        // agora so teremos duas variaveis: X e Y, do tipo Triangulo
        // Triangulo x, y;
        // x = new Triangulo();
        // y = new Triangulo();
        // a variavel x e y vai ser a referencia para um Objeto composto
        // esse OBJETO composto vai conter a, b e c
        // o comando new e necessario quando vc vai trabalhar com classes
        pois e necessario instanciar as variaveis, fazendo ela receber um new 
        com o nome da classe(). essa e a instanciacao, a criacao dos espacos na memoria

        essa instanciacao tambem pode ser chamada de alocacao dinamica de memoria

        x = new Triangulo() vai criar em uma area chamada Heap, uma area de alocacao dinamica
        um objeto composto contendo a, b e c.
        na variavel x, la na area chamada Stack, ira conter o endereco desse objeto, apontando para
        o objeto composto la no heap. Sendo assim, o x e uma referencia para o objeto em si.


*/
        public double A;
        public double B;
        public double C;
    }
}
