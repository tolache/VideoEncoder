using System;
using System.Collections.Generic;
using System.Threading;

namespace VideoEncoder
{
    public class Encoder
    {
        private List<Video> _videos = new List<Video>();
        
        public Encoder(IEnumerable<Video> videos)
        {
            _videos.Clear();
            _videos.AddRange(videos);
        }

        public delegate void VideoEncodedEventHandler(Video video);

        public event VideoEncodedEventHandler OnVideoEncoded;

        public void Encode()
        {
            for (int i = 0; i < _videos.Count; i++)
            {
                Console.Write($"Encoding video {i+1} of {_videos.Count}: {_videos[i]}...");
                Thread.Sleep(3000);
                Console.WriteLine(" Done.");
                OnOnVideoEncoded(_videos[i]);

                if (i == _videos.Count - 1)
                {
                    Console.WriteLine("Finished encoding all videos.");
                }
            }
        }

        protected virtual void OnOnVideoEncoded(Video video)
        {
            OnVideoEncoded?.Invoke(video);
        }
    }
}