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
            Console.WriteLine("b debe ser distinto de 0");
            Matem matem = new Matem();
            Console.Write("a: "); 
            double a= Convert.ToDouble(Console.ReadLine());
            Console.Write("b: "); 
            double b= Convert.ToDouble(Console.ReadLine());

            Console.Write("a/b= ");
            Console.WriteLine(Convert.ToString(matem.Division(a,b)));
            Console.ReadLine();
        }
    }
}
