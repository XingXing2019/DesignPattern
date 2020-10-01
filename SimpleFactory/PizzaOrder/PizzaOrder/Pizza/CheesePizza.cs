using System;

namespace PizzaOrder.Pizza
{
    public class CheesePizza : PizzaBase
    {
        public CheesePizza()
        {
            Name = "Cheese Pizza";
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
        }
    }
}