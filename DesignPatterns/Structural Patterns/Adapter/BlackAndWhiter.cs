using System;

namespace DesignPatterns.Structural_Patterns.Adapter
{
    public class BlackAndWhiter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Apply black and white filter");
        }
    }
}