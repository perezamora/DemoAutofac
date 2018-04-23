using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacMethod
{
    public class Alimento
    {
        public string Nombre { get; set; }
        public Alimento(string nombre)
        {
            Nombre = nombre;
        }
    }
}
