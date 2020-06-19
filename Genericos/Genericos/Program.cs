using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
             AlmacenDeOBjetos<int> almaInt = new AlmacenDeOBjetos<int>(4)  ;
             almaInt.insertarObjeto(32);
             almaInt.insertarObjeto(33);
             almaInt.insertarObjeto(34);
             almaInt.insertarObjeto(35);

             for (int i = 0; i < almaInt.Length() ; i++)
             {
                 Console.WriteLine(almaInt.getItem(i));
             }

             AlmacenDeOBjetos<Object> oBjetos = new AlmacenDeOBjetos<object>(6);

             oBjetos.insertarObjeto("Hola");
             oBjetos.insertarObjeto(true);
             oBjetos.insertarObjeto(10);
             oBjetos.insertarObjeto(10.2);
             oBjetos.insertarObjeto(23.09f);
             oBjetos.insertarObjeto(new Object());
             oBjetos.insertarObjeto(10.2);
             for (int i = 0; i < oBjetos.Length(); i++)
             {
                 Console.WriteLine(oBjetos.getItem(i));
             }
            

          

            AlmacenRestricta<Empleado> empleads = new AlmacenRestricta<Empleado>(5);

            empleads.insertarObjeto(new Director("Federico Vilar",32, 3200));
            empleads.insertarObjeto(new Jefe("Juan Perez",32, 3200));
            empleads.insertarObjeto(new Jefe("Raul Pacheco",32, 3200));
            empleads.insertarObjeto(new Secretaria("Mariana Martinex",32, 3200));
            empleads.insertarObjeto(new Secretaria("Camila BRiscone",32, 3200));
            String a = "";
            int numero = 1;
            for (int i = 0 ; i < empleads.Length(); i++)
            {

                if (empleads.getItem(i).ToString().Contains("Secretaria"))
                {
                     a = $", Soy la secretaria de la empresa numero : {numero}";
                    numero++;
                    
                }
                Console.WriteLine($"Empleado {empleads.getItem(i).getNombre()} salario: {empleads.getItem(i).getSalario()}{a}");
                
            }

        }
    }
    interface IRestrincion
    {
        double getSalario();


    }
    public class Empleado : IRestrincion
    {
        private double edad, salario;
        String nombre;

        public Empleado(String nombre,double edad, double salario) 
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;

        }
        public String getNombre() => this.nombre;
        public double getSalario() => this.salario; 
        public double getedad()=> this.edad;
    }

    public class Secretaria : Empleado
    {
        public Secretaria(String nombre, double edad, double salario) : base(nombre, edad, salario) { }

    }
    public class Director : Empleado
    {
        public Director(String nombre, double edad, double salario) : base(nombre, edad, salario) { }
    }
    public class Jefe : Empleado
    {
        public Jefe(String nombre, double edad, double salario) : base(nombre, edad, salario) { }
    }


    class Jubilado 
    {
    
    
    }

    class AlmacenDeOBjetos<T> 
    {
        private T[] lista;
        private int i;

        public AlmacenDeOBjetos(int largoDelArreglo)
        {
            lista = new T[largoDelArreglo];
        }

        public void insertarObjeto(T obj) 
        {
            if (i < lista.Length )
            {
                lista[i] = obj;
                i++;
            }
            else Console.WriteLine($"Usted agrego {lista.Length+1}" +
                $" elementos cuando declaro {lista.Length} como largo del" +
                $" arreglo\nSolo se agregaran los primeros {lista.Length}");
           
        }
        public T getItem(int z) 
        {
            return lista[z];
        }
        public int Length()
        {
            return lista.Length;
        }
    }

    class AlmacenRestricta<T> where T : IRestrincion
    {
        private T[] lista;
        private int i;

        public AlmacenRestricta(int largoDelArreglo)
        {
            lista = new T[largoDelArreglo];
        }

        public void insertarObjeto(T obj)
        {
            if (i < lista.Length)
            {
                lista[i] = obj;
                i++;
            }
            else Console.WriteLine($"Usted agrego {lista.Length + 1}" +
                $" elementos cuando declaro {lista.Length} como largo del" +
                $" arreglo\nSolo se agregaran los primeros {lista.Length}");

        }
        public T getItem(int z)
        {
            return lista[z];
        }
        public int Length()
        {
            return lista.Length;
        }
    }
}
