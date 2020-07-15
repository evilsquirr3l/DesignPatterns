using System.Collections.Generic;

namespace DesignPatterns.Structural_Patterns.Composite
{
    public class Group  : IComponent
    {
        private ICollection<IComponent> _components = new List<IComponent>();

        public void AddComponent(IComponent component)
        {
            _components.Add(component);
        }
        
        public void Render()
        {
            foreach (var component in _components)
            {
                component.Render();
            }
        }
    }
}