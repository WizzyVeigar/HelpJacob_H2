using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob_H2
{
    interface IMessage
    {
        string Sender { get; set; }
        string[] Receivers { get; set; }
        string Body { get; set; }
        string Subject { get; set; }        
        MessageCarrier MessageType { get; set; }
        MessageModifier MessageModifier { get; set; }
    }
}
