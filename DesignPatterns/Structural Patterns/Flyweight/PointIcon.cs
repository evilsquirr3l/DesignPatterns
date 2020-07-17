namespace DesignPatterns.Structural_Patterns.Flyweight
{
    public class PointIcon
    {
        private PointType _type;
        private byte[] _icon;

        public PointIcon(PointType type, byte[] icon)
        {
            _icon = icon;
            _type = type;
        }
    }
}