using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = IocConfigM.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                container.Resolve<PersonaService>();
            }

            Console.ReadKey();
        }
    }
}
