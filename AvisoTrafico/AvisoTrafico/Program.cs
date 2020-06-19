using System;


namespace AvisoTrafico
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();
            av1.mostrarAviso();
            AvisosTrafico av2 = new AvisosTrafico("Gefatura De Pando", "Multa para recaudar, queremos el aguinaldo papa","24/04/1983");
            av2.mostrarAviso();

        }
    }
}
