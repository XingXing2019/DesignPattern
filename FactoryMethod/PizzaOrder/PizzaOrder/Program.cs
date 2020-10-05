using System;
using PizzaOrder.Pizza;
using PizzaOrder.PizzaFactory;

namespace PizzaOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var italianPizzaFactory = new ItalianPizzaFactory();
            var italianCheesePizza = italianPizzaFactory.CreatePizza("Cheese");
            italianCheesePizza.Prepare();
            italianCheesePizza.Bake();
            italianCheesePizza.Cut();
            Console.WriteLine("------------------------");
            var usaPizzaFactory = new UsaPizzaFactory();
            var usaCheesePizza = usaPizzaFactory.CreatePizza("Cheese");
            usaCheesePizza.Prepare();
            usaCheesePizza.Bake();
            usaCheesePizza.Cut();
        }
    }
}
