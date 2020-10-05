using System;
using PizzaOrder.Pizza;

namespace PizzaOrder.PizzaFactory
{
    public class ItalianPizzaFactory : IPizzaFactory
    {
       
        public PizzaBase CreatePizza(string pizzaName)
        {
            var type = Type.GetType($"PizzaOrder.Pizza.Italian{pizzaName}Pizza");
            return (PizzaBase) Activator.CreateInstance(type, null);
        }
    }
}