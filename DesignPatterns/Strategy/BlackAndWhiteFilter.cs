using System;

namespace DesignPatterns.Strategy
{
    public class BlackAndWhiteFilter : IImageFilter
    {
        public void Filter(string image)
        {
            Console.WriteLine("Apply b&w filter");
        }
    }
}