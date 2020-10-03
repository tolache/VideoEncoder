using System;

namespace VideoEncoder
{
    public class Video
    {
        private int _durationSec;
        private Random _random = new Random();
        public string Title { get; private set; }

        public Video(string title)
        {
            Title = title;
            _durationSec = _random.Next(1,7200);
        }

        private string GetDuration()
        {
            int hours = _durationSec / 3600;
            int minutes = (_durationSec % 3600) / 60;
            int seconds = (_durationSec % 3600) % 60;
            string result = $"{hours:00}:{minutes:00}:{seconds:00}s";
            return result;
        }

        public override string ToString()
        {
            return $"{Title} - {GetDuration()}";
        }
    }
}