using System;
using System.Collections.Generic;
using System.Text;

namespace NotifyExample
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text message...");
        }
    }
}
