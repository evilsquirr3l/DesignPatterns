using System;
using System.Collections.Generic;
using DesignPatterns.Behavioral_Patterns.Visitor;
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
            var library = new Library();
            var fileNames = new List<string>{"Book1", "Book2"};

            foreach (var name in fileNames)
            {
                var ebook = new ProxyEbook(name);
                
                library.Add(ebook);
            }
            
            library.Show("Book1");
        }
    }
}