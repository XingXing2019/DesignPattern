using MilkTeaStore.Drink;

namespace MilkTeaStore.Topping
{
    public class Apple : Topping
    {
        public Apple(DrinkBase drink) : base(drink)
        {
            ItemName = "Apple";
            ItemPrice = 2;
        }
    }
}