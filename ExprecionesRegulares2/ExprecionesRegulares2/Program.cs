using System;
using System.Text.RegularExpressions;

namespace ExprecionesRegulares2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Mi web es https://www.chavetasoft.com , http://www.chavetasoft.com , mis telefonos +55489885544 +598456654";
            string patron = "https?://(www.)?chavetasoft.com?";
            string telefono = @"\+55|\+598";
            Regex miRegex = new Regex(telefono);
            MatchCollection elmatch = miRegex.Matches(frase);
            
            Console.WriteLine("Se encontraron {0} coincidencias.", elmatch.Count);
            foreach (var item in elmatch) Console.WriteLine(item);

        }
    }
}
