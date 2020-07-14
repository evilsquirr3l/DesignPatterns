using System;

namespace DesignPatterns.Behavioral_Patterns.State
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