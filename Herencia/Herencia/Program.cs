using System;


namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballos caballo = new Caballos("Tango");
            Humano humano = new Humano("Juan");
            Gorila gorila = new Gorila("King-kong");
            Ballenas ballena = new Ballenas("Wally");
            Lagartija lagartija = new Lagartija("Rodolfa");

            //Principio de sustitucion (siempre es un)
            /*
            Mamiferos animal = new Mamiferos("Bucefalo");
            Caballos bucefalo = new Caballos("Bucefalo");
            animal = bucefalo;
            object mianimal = new Caballos("mi animal");
            */
            /*
            Mamiferos[] almacendeanimales = new Mamiferos[3];
            almacendeanimales[0] = caballo;
            almacendeanimales[1] = humano;
            almacendeanimales[2] = gorila;
            */

            // Console.WriteLine($"el nombre de caballo es {caballo.getNombre()}");
            /*
            for (int i = 0; i < almacendeanimales.Length; i++)
            {
                almacendeanimales[i].Pensar();
            }
            */
            /*
            ballena.nadar();
            IsaltoConPatas mamterrcaballo = caballo;
            Console.WriteLine( $"numero de patas que salta el caballo {mamterrcaballo.NumeroPatas()}" );
            ballena.Respirar();
            */
            Console.WriteLine( lagartija.getNombre()) ;
            lagartija.Respirar();
            Console.WriteLine(humano.getNombre());
            humano.Respirar();
            
        }
    }
    interface IMamiferosTerrestres 
    {
        int NumeroPatas();
        //no se declara modificaor de accseso ni se desarrolla el codigo
    
    }
    interface IAnimalesYDeportes
    {
        string Deporte();
        bool EsOlimpico();
    }
    interface IsaltoConPatas 
    {
        int NumeroPatas();
    }
    abstract class Animales
    {
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de Respirar");

        }
        public abstract String getNombre();

    }
    class Mamiferos : Animales
    {
        public Mamiferos(String nombreSerVivo)
        {
            this.nombreSerVivo = nombreSerVivo;
        }
        public virtual void Pensar() 
        {
            Console.WriteLine("Pensamiento basico e intuitivo");
        }
        public override String getNombre()
        { 
            return "El nombre del mamifero " + this.nombreSerVivo; 
        }
       
        public void CuidarCrias()
        { 
            Console.WriteLine("Cuido las crias hasta que sean capaces de valerse solos"); 
        }
        private String nombreSerVivo;
    }

    class Caballos : Mamiferos,IMamiferosTerrestres,IAnimalesYDeportes, IsaltoConPatas
    {

        public Caballos(String nombreCaballo) : base(nombreCaballo)
        {
        }

        public string Deporte()
        {
            return "Polo, Carreras";
        }

        public bool EsOlimpico()
        {
            return false;
        }

        public void Galopar() { Console.WriteLine( "Soy capaz de galopar"); }

        int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }

        int IsaltoConPatas.NumeroPatas()
        {
            return 2;
        }
    }
   
    class Humano : Mamiferos 
    {
        public Humano(String nombreHumano) : base(nombreHumano) { }
        public override void Pensar() 
        {
            Console.WriteLine("Soy Capaz de penzar, dicen...");
        }
    }
    class Ballenas : Mamiferos 
    {
        public Ballenas(string nombreBallena) : base(nombreBallena) 
        {
        
        }
        public void nadar() 
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    
    }
    class Gorila : Mamiferos ,IMamiferosTerrestres
    {
        public Gorila
            (String nombreGorila) : base(nombreGorila) { }

        public int NumeroPatas()
        {
            return 2;
        }

        public override void Pensar() 
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
        public void Trepar() 
        {
            Console.WriteLine("Soy capaz de Trepar y como banana a lo loco");
        }
    }

    class Lagartija : Animales
    {
        public Lagartija(String nombre)
        {
            this.nombre = nombre;
        }
        public override string getNombre()
        {
           return "El nombre del reptil es "+nombre;
        }
        String nombre;
    }

}
