using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacMethod
{
    public class PersonaService
    {
        Alimento _alimento;

        public void SetComida(Alimento alimento)
        {
            _alimento = alimento;
        }

        public void MostrarComida()
        {
            Console.WriteLine(string.Format("Hoy he comido {0}", _alimento.Nombre));
        }

    }
}
