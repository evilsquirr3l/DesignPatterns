using System.Collections.Generic;

namespace DesignPatterns.Structural_Patterns.Flyweight
{
    public class PointFactory
    {
        private Dictionary<PointType, PointIcon> _points = new Dictionary<PointType, PointIcon>();

        public PointIcon GetPointIcon(PointType pointType)
        {
            if (_points.ContainsKey(pointType)) return _points[pointType];
            
            var icon = new PointIcon(pointType, null);
            _points.Add(pointType, icon);
                
            return icon;
        }
    }
}