using System;

namespace DesignPatterns.State
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