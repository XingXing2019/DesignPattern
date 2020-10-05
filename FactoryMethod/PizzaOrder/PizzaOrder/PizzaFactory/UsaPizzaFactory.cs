using System;
using PizzaOrder.Pizza;

namespace PizzaOrder.PizzaFactory
{
    public class UsaPizzaFactory : IPizzaFactory
    {
        public PizzaBase CreatePizza(string pizzaName)
        {
            var type = Type.GetType($"PizzaOrder.Pizza.Usa{pizzaName}Pizza");
            return (PizzaBase)Activator.CreateInstance(type, null);
        }
    }
}