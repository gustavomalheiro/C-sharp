
namespace ExercicioMembrosEstaticos {
    class ConversorDeMoeda {

        public static double Iof = 6.0;

        public static double ConverterDolar(double cot, double qtd) {
            double total = cot * qtd;

            return total + ((total * Iof) / 100.0);
        }
    }
}
