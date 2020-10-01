using System;

namespace PizzaOrder.Pizza
{
    public abstract class PizzaBase
    {
        protected string Name { get; set; }

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine($"Baking {Name}");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting {Name}");
        }
    }
}