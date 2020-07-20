using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class CocaColaFactory : AbstractFactory
    {
        public override AbstractWater CreateWater()
        {
            Console.WriteLine("Create water for coca cola");
            
            return new CocaColaWater();
        }

        public override AbstractBottle CreateBottle()
        {
            Console.WriteLine("Create bottle for coca cola");
            
            return new CocaColaBottle();
        }
    }
}