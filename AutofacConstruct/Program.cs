using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacConstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = IocConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var messageservice = container.Resolve<MessageService>();

                Message msg = new Message
                {
                    Title = "Demo autofac",
                    Comment = "Inyection dependency with constructor"
                };

                messageservice.Print(msg);
            }
            Console.ReadKey();
        }
    }
}
