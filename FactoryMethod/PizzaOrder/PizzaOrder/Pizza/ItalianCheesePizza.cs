using System;

namespace PizzaOrder.Pizza
{
    public class ItalianCheesePizza : ItalianPizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Prepare Italian Cheese Pizza");
        }
    }
}