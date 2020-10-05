using System;

namespace PizzaOrder.Pizza
{
    public class UsaCheesePizza : UsaPizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Prepare USA Cheese Pizza");
        }
    }
}