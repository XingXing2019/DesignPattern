using System;
using PizzaOrder.Pizza;

namespace PizzaOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizza = PizzaFactory.CreatePizza();
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
        }
    }
}
