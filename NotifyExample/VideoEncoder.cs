using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NotifyExample
{
    class VideoEncoder
    {
        public event EventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Viedo...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}
