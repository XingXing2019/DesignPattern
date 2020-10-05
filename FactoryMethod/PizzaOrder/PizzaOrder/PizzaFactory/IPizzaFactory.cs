using PizzaOrder.Pizza;

namespace PizzaOrder.PizzaFactory
{
    public interface IPizzaFactory
    {
        PizzaBase CreatePizza(string pizzaName);
    }
}