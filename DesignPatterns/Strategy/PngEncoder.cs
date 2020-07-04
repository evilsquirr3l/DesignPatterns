using System;

namespace DesignPatterns.Strategy
{
    public class PngEncoder : IImageEncoder
    {
        public void Encode(string image)
        {
            Console.WriteLine("Save as png");
        }
    }
}