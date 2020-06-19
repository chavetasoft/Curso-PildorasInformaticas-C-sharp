using System;

namespace EjercicioAreas
{
    class CalculosAreas
    {
        public static double AreaCirculo(double radio) 
        {

            return (Math.Pow(radio, 2) * Math.PI);        
        }

        public static double AreaCuadrado(double lado)
        {

            return Math.Pow(lado, 2);
        }
        public static double AreaRectangulo(double a,double b)
        {
            
            return a*b;
        }

        public static double AreaTriangulo(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c)); 
            return area;
        }

        

    }
}
