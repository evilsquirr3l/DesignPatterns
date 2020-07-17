using System;

namespace DesignPatterns.Structural_Patterns.Decorator
{
    public class CloudStorage : IStream
    {
        public void Write(string data)
        {
            Console.WriteLine($"Storing {data}...");
        }
    }
}