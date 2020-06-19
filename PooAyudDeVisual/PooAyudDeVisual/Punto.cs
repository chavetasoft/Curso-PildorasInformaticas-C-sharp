using System;

namespace PooAyudDeVisual
{
    //todo: clase del tipo punto 
    class Punto

    {
        public Punto()
        {
            Console.WriteLine("Este es el cosntructor por edfecto");
        }

        public Punto(int x, int y)
        {
            Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");
        }
    }

}