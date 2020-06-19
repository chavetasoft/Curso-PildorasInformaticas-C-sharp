using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisoTrafico
{
    class AvisosTrafico : IAvisos
    {
        private string remitente;
        private string mensaje;
        private string fecha;

        public AvisosTrafico()
        {
            remitente = "DGT";
            mensaje = "Sancion cometida. Pague antes de tres dias y se beneficiaria con la reduccion de 50%";
            fecha = "";

        }
        public AvisosTrafico(string remitente,string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }



        public string getFecha()
        {
            return fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine($" {mensaje}.Enviado por {remitente} , el dia {fecha}");        
        }
    }
}
