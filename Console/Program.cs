using System;
using DesignPatterns.Behavioral_Patterns.Visitor;
using DesignPatterns.Structural_Patterns.Composite;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = new Group();
            
            group.AddComponent(new Leaf());
            group.AddComponent(new Leaf());
            
            group.Render();
        }
    }
}