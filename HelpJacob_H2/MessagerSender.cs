using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob_H2
{
    //Class used for sending the Imessage
    class MessagerSender
    {
        private static MessagerSender instance;
        /// <summary>
        /// Singleton instance of the MessageController class
        /// </summary>
        public static MessagerSender Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MessagerSender();
                }
                return instance;
            }
        }

        /// <summary>
        /// Sends the <paramref name="message"/> via SMTP
        /// </summary>
        /// <param name="message">The message to send</param>
        /// <returns>Returns true if successful</returns>
        public bool SendSmtpMessage(IMessage message)
        {
            //Kode til at sende via SMTP
            return true;
        }
        /// <summary>
        /// sends the <paramref name="message"/> via VMessage
        /// </summary>
        /// <param name="message">The message to send</param>
        /// <returns>Returns false if not successful </returns>
        public bool SendVMessage(IMessage message)
        {
            //Kode til at sende via VMessage
            return true;
        }


    }
}
