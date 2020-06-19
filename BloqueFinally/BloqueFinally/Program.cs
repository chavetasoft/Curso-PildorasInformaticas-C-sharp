using System;

namespace BloqueFinally
{
    class Program
    {
        static void Main(string[] args)
        {

            String path = @"C:\Users\Federico Vilar\Desktop\texto.txt";

            LeeArchivoTexto(path);

        }

        public static void LeeArchivoTexto(String path)
        {
            System.IO.StreamReader archivo = null;

            try
            {

                String linea;

                int contador = 0;

                archivo = new System.IO.StreamReader(path);

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("error");

            }
            finally
            {

                if (archivo != null) archivo.Close();
                Console.WriteLine("conexion cerrada");

            }

        }

    }

}
