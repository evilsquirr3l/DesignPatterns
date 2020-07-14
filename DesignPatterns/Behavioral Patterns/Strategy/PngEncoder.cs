using System;

namespace DesignPatterns.Behavioral_Patterns.Strategy
{
    public class PngEncoder : IImageEncoder
    {
        public void Encode(string image)
        {
            Console.WriteLine("Save as png");
        }
    }
}