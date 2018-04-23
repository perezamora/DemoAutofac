using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacMethod
{
    public class IocConfigP
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            //*
            builder.RegisterType<RestauranteService>()
                .WithProperty("Nombre", "Espinete");

            //*
            builder.RegisterType<EscuelaRepository>();
            builder.RegisterType<EscuelaService>()
                   .PropertiesAutowired();

            return builder.Build();
        }
    }
}
