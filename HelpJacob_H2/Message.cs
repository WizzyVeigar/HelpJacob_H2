using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob_H2
{

    public enum MessageCarrier
    {
        SMTP,
        VMessage
    }

    public enum MessageModifier
    {
        IsHtml,
        IsJson
    }

    public class Message : IMessage
    {
        private string sender;

        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }

        private string[] receivers;

        public string[] Receivers
        {
            get { return receivers; }
            set { receivers = value; }
        }

        private string body;

        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        private string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }


        private MessageCarrier messageType;
        public MessageCarrier MessageType
        {
            get
            {
                return messageType;
            }
            set
            {
                messageType = value;
            }
        }

        private MessageModifier messageModifier;
        public MessageModifier MessageModifier
        {
            get
            {
                return messageModifier;
            }
            set
            {
                messageModifier = value;
            }
        }


        public override string ToString()
        {
            string temp = string.Empty;

            for (int i = 0; i < Receivers.Length; i++)
            {
                temp += "Receiver" + (i+1) + ": " + Receivers[i] + "\n";
            }
            temp += "Sender: " + Sender + "\n" +
                "Body of Mail: " + Body + "\n" +
                "Subject: " + Subject + "\n" +
                "MessageType: " + Enum.GetName(typeof(MessageCarrier), MessageType) + "\n" +
                "MessageModifier: " + Enum.GetName(typeof(MessageModifier), MessageModifier);
            return temp;
        }


        //Nice constructor scaffolding

        public Message(string[] to, string from, string body, string subject, MessageCarrier type, MessageModifier modifier) : this(type, modifier)
        {
            Receivers = to;
            Sender = from;
            Body = body;
            Subject = subject;
        }

        public Message(MessageCarrier type, MessageModifier modifier) : this()
        {
            MessageType = type;
            MessageModifier = modifier;
        }

        private Message()
        {
            Receivers = new string[] { "Null" };
            Sender = string.Empty;
            Body = string.Empty;
            Subject = string.Empty;
            MessageModifier = MessageModifier.IsHtml;
        }
    }
}
