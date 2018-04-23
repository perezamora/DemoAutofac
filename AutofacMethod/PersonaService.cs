using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacMethod
{
    public class PersonaService
    {
        Alimento alimento;

        public void SetComida(Alimento alimento)
        {
            Console.WriteLine(string.Format("Hoy he comido {0}", alimento.Nombre));
        }

    }
}
