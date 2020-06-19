using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            String frase = "Mi nombre es Federico Vilar, vivo en Pando-Canelones mis telefonos son +598-99-888-777 , +598-99-558-677";
            String expreg = @"\+598-\d{2}-\d{3}-\d{3}";

            MatchCollection matches = Regex.Matches(frase,expreg);

            Console.WriteLine("Se encontraron {0} coincidencias.", matches.Count);
            foreach (var item in matches) Console.WriteLine(item);
            



        }

    }
}
