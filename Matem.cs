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
            /*int exponente = pExponente;
            double argum = pArgumento;
            double resultado = pArgumento;
            if (exponente != 0)
            {
                resultado = resultado * Potencia(argum, exponente - 1);
            }
            else { return 1; }

            return resultado;*/

            try
            {
                if (pArgumento == 0 && pExponente != 0) 
                {
                    return 0;
                }

                if (pArgumento!=0)
                {
                    switch (pExponente)
                    {
                        case 0: return 1;

                        case 1: return pArgumento;

                        default: return pArgumento * Potencia(pArgumento, pExponente - 1);
                    }
                }
                return -1;
            } 
            catch {
                //Console.WriteLine("Error, potencia indeterminada");
                return -1; 
            }

                  
        }
        public double Division(double pDividendo, double pDivisor)
        {
            try
            {
                if (pDivisor != 0)
                {
                    return pDividendo / pDivisor;
                }
                return -1;
            }
            catch
            {
                //Console.WriteLine("Error, potencia indeterminada");
                return -1;
            }
        }
     }
}
