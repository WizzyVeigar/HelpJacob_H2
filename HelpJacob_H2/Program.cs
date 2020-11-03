using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob_H2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] receivers = { "hi@everyone.dk" };


            IMessage message = new Message(receivers, "Lars@Larsen.dk", "Jeg har et godt tilbud til dig", "Best offer you will ever get", MessageCarrier.VMessage, MessageModifier.IsHtml);

            Console.WriteLine(MessageController.Instance.SendMessage(message));
            Console.WriteLine(message.ToString());
            Console.ReadKey();
        }
    }
}
