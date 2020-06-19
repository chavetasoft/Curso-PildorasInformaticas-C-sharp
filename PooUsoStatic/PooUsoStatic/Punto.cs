using System;

namespace PooUsoStatic
{
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