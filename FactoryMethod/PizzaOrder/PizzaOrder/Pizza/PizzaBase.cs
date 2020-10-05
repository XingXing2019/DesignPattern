using System;

namespace PizzaOrder.Pizza
{
    public abstract class PizzaBase
    {
        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut Pizza");
        }
    }
}