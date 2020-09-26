using MilkTeaStore.Drink;

namespace MilkTeaStore.Topping
{
    public class Pearl : Topping
    {
        public Pearl(DrinkBase drink) : base(drink)
        {
            ItemName = "Pearl";
            ItemPrice = 3;
        }
    }
}