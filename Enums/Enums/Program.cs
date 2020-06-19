using System;


namespace Enums
{ enum bono {ninguno=0, bajo=500,medio=1000,alto=1500, extra=2000 };
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Juan = new Empleado("Juan",1000,bono.ninguno);
            Empleado Jose = new Empleado("Jose ",1000,bono.extra);

            ImprimeInfo(Juan);
            ImprimeInfo(Jose);

        }

        static void ImprimeInfo(Empleado empleado)
          
        {
            Console.WriteLine($"Empleado: {empleado.getNombre()}\nSlario base: {empleado.getSalarioBase()}\nBono: {empleado.getBono()}\nTotal:{empleado.getSalarioTotal()}\n");
        }
    }
    class Empleado
    {
        private double salarioBase, salarioTotal;
        private bono bono;
        String nombre;

        public Empleado(string nombre,double salariobase, bono bono)
        {
            this.salarioBase = salariobase;
            this.bono = bono;
            this.salarioTotal = this.salarioBase + (double)this.bono;
            this.nombre = nombre;

        }
        public double getSalarioBase() => this.salarioBase;
        public bono getBono() => this.bono;
        public double getSalarioTotal() => this.salarioTotal;
        public string getNombre() => this.nombre;
    }

}
