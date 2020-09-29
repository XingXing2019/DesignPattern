using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Catalogue
{
    public class Composite : Component
    {
        private readonly List<Component> _components;
        public Composite(string name) : base(name)
        {
            _components = new List<Component>();
        }

        public override void Add(Component component)
        {
            _components.Add(component);
        }

        public override void Remove(Component component)
        {
            _components.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new string('-', depth)} {Name}");
            foreach (var component in _components)
                component.Display(depth + 1);
        }

        public override int CountArticles()
        {
            int count = 0;
            foreach (var component in _components)
                count += component.CountArticles();
            return count;
        }
    }
}