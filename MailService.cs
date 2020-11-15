using System;

namespace VideoEncoder
{
    public class MailService
    {
        public void VideoEncoded(Video video)
        {
            Console.WriteLine($"Email sent \"{video.Title} - encoded\".");
        }
    }
}