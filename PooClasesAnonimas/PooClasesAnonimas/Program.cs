using System;



namespace PooClasesAnonimas
{
    class Program
    {
        static void Main(string[] args)
        {
            var miVariable = new { Nombre="Minombre", Edad =19};//clase anonima   
            var miOtraVariable = new { Nombre = "Minombre", Edad = 19 };

            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);
            Console.WriteLine(miOtraVariable.Nombre + " " + miOtraVariable.Edad);

        }
        static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(150, 90);
            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine($"La distancia entre los dos puntos es {distancia}");
            Console.WriteLine($"Numero de Objetos creados: {Punto.GetContador()}");

            int a = Punto.variabledeprueba;//accediedo a una constante se permite por que en este caso esta accediendo la clase
            // int b = origen.variabledeprueba; // las constantes se auto determinan static por eso esto daria error al ser una instancia   

        }
    }
    class Punto
    {
        //variables
        private int x;
        private int y;
        //el modificador static solo permite 
        //llamados por la clase y no por las instancias
        private static int contadorDeObjetos = 0;
        public const int variabledeprueba = 8;
        //constructores
        public Punto()
        {
            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            contadorDeObjetos++;

        }
        //metodos
        public static int GetContador()//el modificador static solo permite llamados por la clase y no por las instancias
        {
            return contadorDeObjetos;
        }

        public double DistanciaHasta(Punto otroPunto)
        {
            int xDiff = this.x - otroPunto.x;
            int yDiff = this.y - otroPunto.y;

            //Teorema de Pitagoras Si en un triángulo rectángulo hay catetos de longitud a y b
            //y la medida de la hipotenusa es c, entonces se cumple la siguiente relación:
            // c² = a² + b²
            //      ________
            // c = √ a² + b²

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
            return distanciaPuntos;
        }
    }
}
