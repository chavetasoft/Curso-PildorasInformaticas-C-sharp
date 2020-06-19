namespace EjercicioAreas
{
    class Arreglos
    {   //Metodo de ordenamiento  bubbleSort
        public static void BubleSort(int[] vs)
        {

            int aux;
            for (int i = 0; i <= vs.Length - 2; i++)
            {
                for (int j = 0; j <= vs.Length - 2; j++)
                {
                    if (vs[j] > vs[j + 1])
                    {
                        aux = vs[j + 1];
                        vs[j + 1] = vs[j];
                        vs[j] = aux;
                    }
                }
            }


        }
        //metodo que devuelve el valor menor de un arreglo de enteros
        public static int Menor(int[] vs)
        {
            int menor = vs[0];

            for (int i = 0; i < vs.Length; i++)
            {
                if (vs[i]< menor) {

                    menor = vs[i];
                }

            }

            return menor;
        }
        //metodo que devuelve el valor mayor de un arreglo de enteros
        public static int Mayor(int[] vs)
        {
            int mayor = vs[0];

            for (int i = 0; i < vs.Length; i++)
            {
                if (vs[i] > mayor)
                {
                    mayor = vs[i];
                }

            }

            return mayor;
        }
        //metodo que devuelve el promedio de los valores de un arreglo de enteros

        public static double Promedio(int[] vs)
        {
            int nElementos = vs.Length ;
            int sumaValores = 0;
            for (int i = 0; i<vs.Length; i++) 
            {
                sumaValores += vs[i];
            }
            return sumaValores/nElementos;
        }

    }

}
