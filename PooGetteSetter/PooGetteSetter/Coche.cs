using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooGetterSetter
{
    internal partial class Coche
    {
        //***********************Metodos Clase coche ***************************
        public void setExtras(bool climatizador, String tapizaria)
        {
            this.tapizeria = tapizaria;
            this.climatizador = climatizador;
        }
        public String getExtras()
        {
            String clima = " no tiene climatizador";
            if (climatizador)
            {
                clima = " tiene climatizador";
            }
            return ($"Extras del coche :\n Tiene un tapizado de {tapizeria} y {clima}\n");
        }
        public String GetInfoCoche()
        {

            return ($"Informacion del coche :\n Este coche tiene {ruedas} ruedas, {largo} de largo, {ancho} de ancho.\n");

        }
    }
    //***************************Variables Y constructores***********************
    internal partial class Coche
    {
        //constructores
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 1200;
            climatizador = false;
            tapizeria = "tela";
        }
        public Coche(double largo, double ancho)
        {
            ruedas = 4;
            this.largo = largo;
            this.ancho = ancho;
            this.tapizeria = "tela";
            this.climatizador = false;

        }
        //variables encapsuladas
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapizeria;
    }


}
