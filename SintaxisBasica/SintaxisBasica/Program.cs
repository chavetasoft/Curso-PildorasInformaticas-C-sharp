using System;


namespace SintaxisBasica
{
    class Program
    {
        static void Main(string[] args)
        {

            /* TIPO DE DATOS NUMERICOS
            sbyte       -128 a 127	
            byte        0 a 255	
            short       -32768 a 32767	
            ushort      0 a 65535	
            int	        -2147483648 a 2147483647	
            uint	    0 a 4294967295	
            long	    -9223372036854775808 a 9223372036854775807	
            ulong	    0 a 18446744073709551615	
             */

            //Enteros con signos
            sbyte a = -128;
            short b = -32768;
            int c = -2147483648;
            long d = -9223372036854775808;
            //enteros sin signos
            byte e = 255;
            ushort f = 32768;
            uint g = 4294967295;
            ulong h = 18446744073709551615;


            /*
             operadores arimetricos
                +    suma, y concateacion de strings
                -    resta
                /    division   
                *    multiplicacion
                %    modulo(resto de la division)
                ++   Incrementa 1 se pueden utilizar como prefijos o subfijos ej: variable++, ++variable
                --   decrementa 1
                +=5  incrementa 5 (o el valor que se coloque despues de =)
                -=5  decrementa 5 (o el valor que se coloque despues de =)
             */
            //interpolar strings
            String inter = "interpolacion";
            Console.WriteLine($"ESto es una {inter} de strings");
            Console.ReadKey();

            //asignacion de valores variables explicitas
            int va;
            int vb;
            int vc;
            int vd;
            va = vb = vc = vd = 1; // aca asignamos el mismo valor a vrias variables

            //declaracion implicita de variables
            var variableImplicita = 27;/* se asigna el tipo de valor en tiempo de ejecucion 
                                        * en este caso int por ejemplo podria ser cuaklquier otro tipo de datos
                                        * pero es inmutable una ves asignado no puede cambiar por ejemplo este int
                                        * nunca podra recivir valores de otrotipo como double o float o string etc
                                        * tampoco se puede declarar una variable implicita sin inizializar
                                        */
            //converciones explicitas (casting)


            double temperatura = 34.5;

            int temperaturaMadrid = (int)temperatura;// no redondea desprecia la parte decimal


            // conveciones implicitas (casting) entre tipos compatibles pero de diferente alcanze

            int poblacion = 1000000;
            long poblaciolong = poblacion;

            float poblaacionFloat = 724.78F;// los float siempre llevan el subfijo F al final
            double poblacionDouble = poblaacionFloat;


            // conversiones de tipos (casting) 
            // por ejemplo  String  a int

            String valorString = "5";
            int valorint = int.Parse(valorString);

            int valorDeConsola = int.Parse(Console.ReadLine());

            // variables vs constantes

            /*
                * las variables son un espacio en memoria donde pueden cambiar su valor en la ejecucione del programa
                * las constantes son estaticas y no permiten el cambio de su valor una vez designado en toda la ejecucion del programa las mismas
                    -   deben ser declaradas y inizializadas en una misma linea 
                    -   POR CONVENCION LAS CONSTANTES SE ESCRIBEN EN MAYUSCULAS
             
             */

            //variables 
            int variable;
            String hola = "hola copmo estas ;";

            //constantes
            const int CONSTANTE = 0;
           //const double PI = 3.1416;
                                //clase Math
            const double  PI = Math.PI;
            double radio = 3;
            double areacirculo = Math.Pow(radio, 2)*PI; 
            
        }
    }
}
/*
   * dejar sangria entre bloques de codigo
   * clases variables namspace no pueden llevar nombres iguales a palabras reservadas
   * las clases y namespaces admiten letras numeros y guion bajo pero el los numeros no pueden ir al primcipio del nombre
            ej: EsteNombreEsValido1
                _EsteNombreEsValido            buenas practicas
                2EsteNombreEstaMal
   * las variables son un espacio en memoria reservado el cual puede cambiar su informacion en la ejecucion del programa
   * se declaran con el nombre en minuscula  buenas practicas
            ej: nombre
                nombreVariable
                nombreVariable2


*******************TIPS***************************************************
    *cw y tabulador dos veces genera automaticamente Console.WriteLine();
    *ctrl + f5 inicia sin depurar
    *f6 compila
    *ctrl+s guarda el archivo
**************************************************************************      
 */


//comentario de una linea

/*
     comentario de 
    varias lineas
    tipo folder
 */
