using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacConstruct
{
    public class MessageService
    {
        private readonly IMessageRepository repositoryMessage;

        public MessageService(IMessageRepository repository)
        {
            repositoryMessage = repository;
        }

        public void Print(Message message)
        {
            repositoryMessage.PrintMessage(message);
        }
    }
}
