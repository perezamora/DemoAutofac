using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacProperty
{
    public class RestauranteService
    {
        public string Nombre { get; set; }

        public RestauranteService() { }

        public void PrintNombre()
        {
            Console.WriteLine("El nombre del restaurante :");
            Console.WriteLine(string.Format("Nombre : {0}", Nombre));
        }
    }
}
