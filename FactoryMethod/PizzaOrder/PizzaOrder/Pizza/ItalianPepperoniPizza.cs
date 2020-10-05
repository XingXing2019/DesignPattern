using System;

namespace PizzaOrder.Pizza
{
    public class ItalianPepperoniPizza : ItalianPizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Prepare Italian Pepperoni Pizza");
        }
    }
}