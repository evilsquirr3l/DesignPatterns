using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Creational.Builder
{
    public class House
    {
        ICollection<string> _elements = new List<string>();

        public void Add(string element)
        {
            _elements.Add(element);
        }

        public override string ToString()
        {
            return _elements.Aggregate("", (current, element) => current + "\n" + element);
        }
    }
}