
namespace Exercicio4 {
    class Aluno {

        public string Nome;
        public double N1, N2, N3;

        public double NotaFinal() {
            return N1 + N2 + N3;
        }

        public string SituacaoAluno() {

            double minimo = 60.0;

            if (NotaFinal() < minimo) {
                return $"REPROVADO\n" +
                    $"FALTARAM {(minimo - NotaFinal()).ToString("F2")}"  
                    + " PONTOS";
            }

            return "APROVADO";
        }

        public override string ToString() {

            return "NOTA FINAL = "
                + NotaFinal()
                + "\n"
                + SituacaoAluno();
        }
    }
}
