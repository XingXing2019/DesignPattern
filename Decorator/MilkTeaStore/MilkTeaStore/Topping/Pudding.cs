using MilkTeaStore.Drink;

namespace MilkTeaStore.Topping
{
    public class Pudding : Topping
    {
        public Pudding(DrinkBase drink) : base(drink)
        {
            ItemName = "Pudding";
            ItemPrice = 4;
        }
    }
}