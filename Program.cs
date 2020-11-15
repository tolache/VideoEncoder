using System.Collections.Generic;

namespace VideoEncoder
{
    static class Program
    {
        static void Main()
        {
            List<Video> videos = new List<Video>()
            {
                new Video("Memes"),
                new Video("Cats"),
                new Video("Music")
            };
            Encoder encoder = new Encoder(videos);
            MailService mailService = new MailService();
            encoder.VideoEncoded += mailService.VideoEncoded;
            encoder.Encode();
        }
    }
}