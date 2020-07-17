using System.Collections.Generic;

namespace DesignPatterns.Structural_Patterns.Flyweight
{
    public class PointService
    {
        private ICollection<Point> _points = new List<Point>();
        private PointFactory _pointFactory;

        public PointService(PointFactory pointFactory)
        {
            _pointFactory = pointFactory;
        }

        public ICollection<Point> GetPoints()
        {
            var point = new Point(1, 2, _pointFactory.GetPoint(PointType.Cafe));
            _points.Add(point);

            return _points;
        }
    }
}