using System;
using DesignPatterns.Behavioral_Patterns.Visitor;
using DesignPatterns.Structural_Patterns.Adapter;
using DesignPatterns.Structural_Patterns.Composite;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var image = new Image();
            var imageView = new ImageView(image);
            
            imageView.ApplyFilter(new BlackAndWhiter());
            imageView.ApplyFilter(new BigHeadFilterAdapter(new BigHeadFilter()));
        }
    }
}