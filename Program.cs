using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisoTrafico Avi1 = new AvisoTrafico();
            Avi1.MostrarAviso();

            Console.WriteLine(" ");

            AvisoTrafico Avi2 = new AvisoTrafico("transito de envigado","ha sido sancionado","19/09/2023");
            Avi2.MostrarAviso();
        }
    }
}
