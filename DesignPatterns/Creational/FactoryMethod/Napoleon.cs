using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Napoleon : Cake
    {
        public Napoleon()
        {
            Console.WriteLine("Create worst cake in the history of cakes!!!");
        }
    }
}