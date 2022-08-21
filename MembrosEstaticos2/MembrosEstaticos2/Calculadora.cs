using System;
/*
 * Discussao
 * 
 * - No problema dos triangulos, cada triangulo possui sua area
 * - Area() e uma operacao concernente ao objeto: cada triangulo possui sua area
 * 
 * - Ja no caso da calculadora, os valores dos calculos nao mudam para calculadoras
 *   diferentes, ou seja, sao calculos estaticos. O valor de Pi tambem e estatico.
 * 
 * - Isso e uma pista de que isso na verdade e uma classe estatica
 * - As operacoes da calculadora nao tem uma dependencia para os objetos
 * 
 * 
 */

namespace MembrosEstaticos2 {
    class Calculadora {

         public static double Pi = 3.14;

         public static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }

         public static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(3, r);
        }
    }
}
