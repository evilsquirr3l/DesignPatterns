using System;

namespace DesignPatterns.Structural_Patterns.Flyweight
{
    public class Point
    {
        private int _x;
        private int _y;
        private PointIcon _pointIcon;

        public Point(int x, int y, PointIcon pointIcon)
        {
            _x = x;
            _y = y;
            _pointIcon = pointIcon;
        }

        public void Draw()
        {
            Console.WriteLine($"Point at {_x}, {_y}");
        }
    }
}