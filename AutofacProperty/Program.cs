using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = IocConfigP.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var restaurante = container.Resolve<RestauranteService>();
                var escuela = container.Resolve<EscuelaService>();

                restaurante.PrintNombre();
                escuela.PrintEscuela();
                escuela.PrintNombre();
            }
            Console.ReadKey();
        }
    }
}
