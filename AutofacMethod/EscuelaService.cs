using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacMethod
{
    public class EscuelaService
    {
        private string calle = "Calle Alcala la de la puerta de la cancion";
        public EscuelaRepository escuela { get; set; }

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public void PrintEscuela()
        {
            Console.WriteLine(string.Format("Calle : {0}", Calle));
        }

        public void PrintNombre()
        {
            escuela.PrintNombre();
        }
    }
}
