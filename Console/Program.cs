using System;
using DesignPatterns.Behavioral_Patterns.Visitor;
using DesignPatterns.Structural_Patterns.Adapter;
using DesignPatterns.Structural_Patterns.Composite;
using DesignPatterns.Structural_Patterns.Decorator;
using DesignPatterns.Structural_Patterns.Flyweight;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var pointService = new PointService(new PointFactory());

            foreach (var point in pointService.GetPoints())
            {
                point.Draw();
            }
        }
    }
}