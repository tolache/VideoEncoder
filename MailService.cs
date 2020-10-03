using System;

namespace VideoEncoder
{
    public class MailService
    {
        public void OnVideoEncoded(Video video)
        {
            Console.WriteLine($"Email sent \"{video.Title} - encoded\".");
        }
    }
}