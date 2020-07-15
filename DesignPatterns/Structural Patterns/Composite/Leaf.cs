using System;

namespace DesignPatterns.Structural_Patterns.Composite
{
    public class Leaf : IComponent
    {
        public void Render()
        {
            Console.WriteLine("Render leaf");
        }
    }
}