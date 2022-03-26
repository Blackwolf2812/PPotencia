using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPotencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor usar un b mayor que 0.");
            Matem matem = new Matem();
            Console.Write("a: "); 
            double a= Convert.ToDouble(Console.ReadLine());
            Console.Write("b: "); 
            int b= Convert.ToInt32(Console.ReadLine());

            Console.Write("a^b= ");
            Console.WriteLine(Convert.ToString(matem.Potencia(a,b)));
            Console.ReadLine();
        }
    }
}
