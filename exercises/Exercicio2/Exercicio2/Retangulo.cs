using System;

namespace Exercicio2 {
    class Retangulo {

        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return 2 * (Altura + Largura);
            
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }

        public override string ToString() {
            return "AREA = "
                + Area().ToString("F2")
                + "\nPERIMETRO = "
                + Perimetro().ToString("F2")
                + "\nDIAGONAL = "
                + Diagonal().ToString("F2");
        }
    }
}
