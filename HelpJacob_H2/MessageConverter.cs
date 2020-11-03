using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob_H2
{
    //Used for any convertion needed within the Imessage object
    class MessageConverter
    {
        private static MessageConverter instance;
        /// <summary>
        /// Singleton instance of the MessageController class
        /// </summary>
        public static MessageConverter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MessageConverter();
                }
                return instance;
            }
        }

        /// <summary>
        /// Converts the messages body to HTML
        /// </summary>
        /// <param name="message">The message which body you want to Convert</param>
        /// <returns>Returns the messages converted body</returns>
        public string ConvertBodyToHtml(string message)
        {
            return "" + message + "";
        }
        /// <summary>
        /// Converts the messages body to Json
        /// </summary>
        /// <param name="message">The message which body you want to Convert</param>
        /// <returns>Returns the messages converted body</returns>
        public string ConvertBodyToJson(string message)
        {
            return "{" + message + "}";
        }
    }
}
