using System;

namespace Catalogue
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Add(Component component)
        {
            throw new System.InvalidOperationException("Leaf cannot add component");
        }

        public override void Remove(Component component)
        {
            throw new System.InvalidOperationException("Leaf cannot remove component");
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new string('-', depth)} {Name}");
        }

        public override int CountArticles()
        {
            return 1;
        }
    }
}