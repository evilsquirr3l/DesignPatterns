using System;

namespace DesignPatterns.Behavioral_Patterns.Strategy
{
    public class BlackAndWhiteFilter : IImageFilter
    {
        public void Filter(string image)
        {
            Console.WriteLine("Apply b&w filter");
        }
    }
}