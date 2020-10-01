using System;

namespace PizzaOrder.Pizza
{
    public class PepperoniPizza : PizzaBase
    {
        public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
        }
    }
}