using System;

namespace PizzaOrder.Pizza
{
    public class GreekPizza : PizzaBase
    {
        public GreekPizza()
        {
            Name = "Greek Pizza";
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
        }
    }
}