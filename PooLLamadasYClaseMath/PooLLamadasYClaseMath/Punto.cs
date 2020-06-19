using System;

namespace PooLLamadasYClaseMath
{
    internal class Punto
    {
        private int x;
        private int y;

        public Punto()
        {
            this.x = 0;
            this.y = 0;
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double distanciaHasta( Punto otroPunto)
        {
            int xDiff = this.x - otroPunto.x;
            int yDiff = this.y - otroPunto.y;

            //Teorema de Pitagoras Si en un triángulo rectángulo hay catetos de longitud a y b
            //y la medida de la hipotenusa es c, entonces se cumple la siguiente relación:
            // c² = a² + b²
            //      ________
            // c = √ a² + b²

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDiff,2)+Math.Pow(yDiff, 2));
            return distanciaPuntos;
        }
    }
}