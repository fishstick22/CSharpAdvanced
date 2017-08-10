using System;

namespace CSharpAdvanced.EventsAndDelegates
{
    public class MessageService
    {

        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending message..." + e.Video.Title);
        }
    }
}
