using System;
using DesignPatterns.Iterator;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var history = new History("1", "2", "3", "4");

            var iterator = history.IterateInReverseOrder();

            while (iterator.MoveNext())
            {
                System.Console.WriteLine(iterator.Current);
            }
        }
    }
}