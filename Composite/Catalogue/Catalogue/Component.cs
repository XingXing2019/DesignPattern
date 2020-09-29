using System.Runtime.Intrinsics.X86;

namespace Catalogue
{
    public abstract class Component
    {
        public string Name { get; set; }

        protected Component(string name)
        {
            Name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);
        public abstract int CountArticles();
    }
}