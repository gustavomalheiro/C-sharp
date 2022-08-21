
namespace ExercicioSecao5 {
    class ContaBancaria {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
            // Saldo = 0.0; -> nao definindo ja recebe 0 automaticamente por ser numerico
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this (numero, titular) {
            // a logica de deposito esta encapsulada no metodo deposito.
            // se um dia a logica de deposito mudar, aqui estara de acordo com o metodo
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= (quantia + 5.00);
        }

        public override string ToString() {
            return "Conta "
                + Numero // propriedade Numero
                + ", Titular: "
                + Titular // propriedade Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2"); // propriedade Saldo
        }

    }
}
