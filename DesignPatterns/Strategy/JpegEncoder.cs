using System;

namespace DesignPatterns.Strategy
{
    public class JpegEncoder : IImageEncoder
    {
        public void Encode(string image)
        {
            Console.WriteLine("Save as jpeg");
        }
    }
}