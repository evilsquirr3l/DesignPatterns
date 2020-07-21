using System;
using System.Collections.Generic;
using DesignPatterns.Behavioral_Patterns.Visitor;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Structural_Patterns.Adapter;
using DesignPatterns.Structural_Patterns.Bridge;
using DesignPatterns.Structural_Patterns.Composite;
using DesignPatterns.Structural_Patterns.Decorator;
using DesignPatterns.Structural_Patterns.Flyweight;
using DesignPatterns.Structural_Patterns.Proxy;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new Builder();
            var foreman = new Foreman(builder);
            
            foreman.Construct();

            System.Console.WriteLine(builder.GetResult());
        }
    }
}