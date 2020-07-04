using System;

namespace DesignPatterns.Strategy
{
    public class WidePutinWalksFilter : IImageFilter
    {
        public void Filter(string image)
        {
            Console.WriteLine("Apply wide filter");
        }
    }
}