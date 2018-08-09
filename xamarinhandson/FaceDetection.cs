using System;
namespace xamarinhandson
{
    public class FaceDetection
    {
        public string Emotion { get; set; }
        public double Smile { get; set; }
        public string Glasses { get; set; }
        public string Gender { get; set; }
        public double Age { get; set; }
        public double Beard { get; set; }
        public double Moustache { get; set; }

        public float Anger { get; set; }
        public float Contempt { get; set; }
        public float Disgust { get; set; }
        public float Fear { get; set; }
        public float Happiness { get; set; }
        public float Neutral { get; set; }
        public float Sadness { get; set; }
        public float Surprise { get; set; }
    }
}
