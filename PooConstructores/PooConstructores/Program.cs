using System;


namespace PooConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();
            Console.WriteLine(coche1.GetInfoCoche());
            Coche coche2 = new Coche(1800,1000, true,"de cuero");
            Console.WriteLine(coche2.GetInfoCoche());



        }
    }
    class Coche
    {
        //constructor
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 1200;
            climatizador = false;
            tapizeria = "estandar";
        }
        public Coche(double elLargo, double elAncho , Boolean tieneClimatizador, String tipoTapizado)
        {
            ruedas = 4;
            largo = elLargo;
            ancho = elAncho;
            climatizador = tieneClimatizador;
            tapizeria = tipoTapizado;
        }
        //metodo de acseso a la variable ruedas desde otra clase GETTER
        public int GetRuedas()
        {
            return ruedas;
        }
        //metodo de seteo de cantidad de ruedas SETTER
        public void SetRuedas(int cantidadRueas)
        {
            ruedas = cantidadRueas;
        }
        public String GetInfoCoche()
        {
            String tieneClimatizador = "";
            if (climatizador)
            {
                tieneClimatizador = "y tiene climatizador";
            }
            return ($"EL coche tiene {ruedas} ruedas, {largo} de largo, {ancho} de ancho ,tapizeria {tapizeria} {tieneClimatizador}"); 
        
        }

        //variables encapsuladas
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapizeria;
    }
}
