using System;

namespace DesignPatterns.Behavioral_Patterns.Visitor
{
    public class ConcreteOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("Logic for heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Logic for anchor");
        }
    }
}