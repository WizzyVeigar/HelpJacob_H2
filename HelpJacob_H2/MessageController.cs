using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob_H2
{
    class MessageController
    {
        private static MessageController instance;
        /// <summary>
        /// Singleton instance of the MessageController class
        /// </summary>
        public static MessageController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MessageController();
                }
                return instance;
            }
        }

        /// <summary>
        /// Sends the message
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool SendMessage(IMessage message)
        {
            DefineMessage(message);

            switch (message.MessageType)
            {
                case MessageCarrier.Smtp:
                    return MessagerSender.Instance.SendSmtpMessage(message);
                case MessageCarrier.VMessage:
                    return MessagerSender.Instance.SendVMessage(message);
                default:
                    return false;
            }
        }
        /// <summary>
        /// Used for defining the <see cref="MessageModifier"/> and invoking the correct convert method
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Returns the message converted</returns>
        public IMessage DefineMessage(IMessage message)
        {
            switch (message.MessageModifier)
            {
                case MessageModifier.IsHtml:
                    MessageConverter.Instance.ConvertBodyToHtml(message.Body);
                    break;
                case MessageModifier.IsJson:
                    MessageConverter.Instance.ConvertBodyToJson(message.Body);
                    break;
            }
            return message;
        }

    }
}
