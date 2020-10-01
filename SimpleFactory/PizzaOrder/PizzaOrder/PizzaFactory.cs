using System;
using PizzaOrder.Pizza;

namespace PizzaOrder
{
    public class PizzaFactory
    {
        private static readonly string _pizzaName = "CheesePizza";
        public static PizzaBase CreatePizza()
        {
            var type = Type.GetType($"PizzaOrder.Pizza.{_pizzaName}");
            return type == null ? null : (PizzaBase) Activator.CreateInstance(type, null);
        }
    }
}