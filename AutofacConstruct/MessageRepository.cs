using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacConstruct
{
    public class MessageRepository : IMessageRepository
    {
        public void PrintMessage(Message message)
        {
            Console.WriteLine("Message say: ");
            Console.WriteLine(string.Format("Title : {0}", message.Title));
            Console.WriteLine(string.Format("Comment : {0}", message.Comment));
        }
    }
}
