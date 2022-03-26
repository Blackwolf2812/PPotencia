using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPotencia
{
    public class Matem
    {
        public Matem() { }

        public double Potencia(double pArgumento, int pExponente) 
        {
            int exponente = pExponente;
            double argum = pArgumento;
            double resultado = pArgumento;
            if (exponente != 0)
            {
                resultado = resultado * Potencia(argum, exponente - 1);
            }
            else { return 1; }

            return resultado;
        }
    }
}
