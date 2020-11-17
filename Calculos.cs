using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Calculos
    {
        public int Somar(int numero1, int numero2)
        {
            numero1 += numero2;
            return numero1;
        }
        public int Subtrair(int numero1, int numero2)
        {
            numero1 -= numero2;
            return numero1;
        }
        public int Multiplicar(int numero1, int numero2)
        {
            numero1 *= numero2;
            return numero1;
        }
        public int Dividir(int numero1, int numero2)
        {
            numero1 /= numero2;
            return numero1;
        }
    }
}
