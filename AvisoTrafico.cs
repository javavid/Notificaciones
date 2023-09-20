using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificaciones
{
    internal class AvisoTrafico : INotificaciones
    {
        private string Remitente;
        private string Mensaje;
        private string Fecha;

        public string GetFecha()
        {
            return Fecha;
        }

        public void MostrarAviso()
        {
            Console.WriteLine("mensaje: {0} ha sido enviado por: {1} el dia: {2}",Mensaje,Remitente,Fecha);
        }

        public AvisoTrafico()
        {
            Remitente = "secretaria de mobilidad transito de envigado";
            Mensaje = "sancion, pagar antes de los 5 dias,para evitar una futara sancion, con el curso se le reducira el parte.  ";
            Fecha = "";
        }

        public AvisoTrafico(string remitente, string mensaje, string fecha)
        {
           this.Remitente = remitente;
            this.Mensaje = mensaje;
            this.Fecha = fecha;
        }
    }
}
