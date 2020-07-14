using System;

namespace DesignPatterns.Behavioral_Patterns.State
{
    public class Selection : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection mouse down");
        }

        public void MouseUp()
        {
            Console.WriteLine("Selection mouse up");
        }
    }
}