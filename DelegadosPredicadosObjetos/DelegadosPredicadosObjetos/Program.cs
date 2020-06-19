using System;
using System.Collections.Generic;


namespace DelegadosPredicadosObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listapersonas = new List<Persona>();
            Persona p1 = new Persona("Federico", 9);
            Persona p2 = new Persona("Maria", 1);
            Persona p3 = new Persona("Juan", 9);
            Persona p4 = new Persona("MArtin", 9);

            listapersonas.AddRange(new Persona[] { p1, p2, p3, p4 });
            Predicate<Persona> predicate = new Predicate<Persona>(EsMayor);

            bool hayMayores = listapersonas.Exists(predicate);
            if (hayMayores)
            {
                Console.WriteLine("Hay mayores ...");
            }
            else
            {
                Console.WriteLine("No hay mayores");

            }
            predicate = new Predicate<Persona>(HayJuan);

            bool hayJuan = listapersonas.Exists(predicate);

            if (hayJuan) Console.WriteLine("Hay Juan ");
            else Console.WriteLine("No hay juan");


            List<NombrePersonaYNombreBuscado> listaParaBuscar = new List<NombrePersonaYNombreBuscado>();
            String buscado = "Juasn";
            foreach (Persona persona in listapersonas)
            {
              
                listaParaBuscar.Add(new NombrePersonaYNombreBuscado(buscado, persona));
            }

            Predicate<NombrePersonaYNombreBuscado> predicate2 = new Predicate<NombrePersonaYNombreBuscado>(HayXPersona);
            bool hayXPersona = listaParaBuscar.Exists(predicate2);
            if (hayXPersona) Console.WriteLine($"Existe {buscado}");
            else Console.WriteLine($"No existe {buscado}");





        }
        //predicados
        static bool EsMayor(Persona persona)
        {
            if (persona.Edad > 18) return true;
            else return false;
        }
        static bool HayJuan(Persona persona)
        {
            if (persona.Nombre == "Juan")return true;
            else return false;
        
        }
        static bool HayXPersona(NombrePersonaYNombreBuscado personaynombre) 
        {
            if (personaynombre.NombreBuscado == personaynombre.Nombredepersona) return true;
            else return false;
        
        }

        //clases
        class Persona 
        {
            private String nombre;
            private int edad;

            public Persona(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }

            public string Nombre { get => nombre; set => nombre = value; }
            public int Edad { get => edad; set => edad = value; }
        }
        class NombrePersonaYNombreBuscado 
        {
         
            String nombredepersona;
            String nombreBuscado;

            public NombrePersonaYNombreBuscado(string nombreBuscado, Persona p)
            {
                NombreBuscado = nombreBuscado;               
                Nombredepersona = p.Nombre;
            }

            public string NombreBuscado { get => nombreBuscado; set => nombreBuscado = value; }
            public string Nombredepersona { get => nombredepersona; set => nombredepersona = value; }
        }
    }
}
