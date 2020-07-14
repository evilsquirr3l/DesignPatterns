using System.Collections.Generic;

namespace DesignPatterns.Behavioral_Patterns.Visitor
{
    public class HtmlDocument
    {
        private ICollection<IElement> _elements = new List<IElement>();

        public void Add(IElement element) => _elements.Add(element);

        public void Execute(IOperation operation)
        {
            foreach (var element in _elements)
            {
                element.Execute(operation);
            }
        }
    }
}