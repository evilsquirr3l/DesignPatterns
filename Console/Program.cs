using System;
using DesignPatterns.Iterator;
using DesignPatterns.Strategy;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var image = "someImage";
            
            var imageStorage = new ImageStorage();
            imageStorage.Save(image, new PngEncoder(), new WidePutinWalksFilter());
        }
    }
}