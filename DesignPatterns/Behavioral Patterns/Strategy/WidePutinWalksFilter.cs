using System;

namespace DesignPatterns.Behavioral_Patterns.Strategy
{
    public class WidePutinWalksFilter : IImageFilter
    {
        public void Filter(string image)
        {
            Console.WriteLine("Apply wide filter");
        }
    }
}