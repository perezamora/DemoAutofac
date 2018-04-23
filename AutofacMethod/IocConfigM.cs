using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacMethod
{
    public class IocConfigM
    {


        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            /* IComponentContext *
            builder.Register(c => {
                var carmen = new PersonaService();
                var dep = c.Resolve<Alimento>();
                carmen.SetComida(dep);
                return carmen;
            }); */

            builder.RegisterType<PersonaService>()
                .OnActivated(paco => paco.Instance.SetComida(new Alimento("Fruta")));

            return builder.Build();
        }
    }
}
