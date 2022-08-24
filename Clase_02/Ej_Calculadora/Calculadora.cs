using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Calculadora
{
    internal class Calculadora
    {
        public static float Calcular(int numero1, int numero2, string operacion)
        {

            if (operacion == "Suma")
            {
                return numero1 + numero2;
            }
            if (operacion == "Resta")
            {
                return numero1 - numero2;
            }
            if (operacion == "Multiplicacion")
            {
                return numero1 * numero2;
            }
            if (operacion == "Division" && Validar(numero2))
            {
                return  (float) numero1 / numero2;
            }

            return 0;
        }

        private static bool Validar (int numero)
        {
            return numero != 0;
        }
    }
}
