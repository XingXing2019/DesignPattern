using System;

namespace PizzaOrder.Pizza
{
    public class UsaPepperoniPizza : UsaPizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Prepare USA Pepperoni Pizza");
        }
    }
}