using System;
using DesignPatterns.Iterator;
using NUnit.Framework;

namespace DesignPatternsTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Iterator()
        {
            var history = new History("1", "2", "3", "4");

            foreach (var item in history)
            {
                Console.WriteLine(item);
            }
        }
    }
}