using System;

namespace DesignPatterns.State
{
    public class Brush  : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush mouse down");
        }

        public void MouseUp()
        {
            Console.WriteLine("Brush mouse up");
        }
    }
}