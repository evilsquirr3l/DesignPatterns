using System;

namespace DesignPatterns.Behavioral_Patterns.Strategy
{
    public class JpegEncoder : IImageEncoder
    {
        public void Encode(string image)
        {
            Console.WriteLine("Save as jpeg");
        }
    }
}