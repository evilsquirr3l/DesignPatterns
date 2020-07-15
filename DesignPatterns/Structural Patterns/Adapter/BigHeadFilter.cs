using System;

namespace DesignPatterns.Structural_Patterns.Adapter
{
    public class BigHeadFilter
    {
        public void Init()
        {
            Console.WriteLine("Init method");
        }
        
        public void ApplyFilter(Image image)
        {
            Console.WriteLine("Apply filter that does not implement interface.");
        }
    }
}