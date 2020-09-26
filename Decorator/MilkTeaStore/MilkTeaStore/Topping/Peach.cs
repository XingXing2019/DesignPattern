using MilkTeaStore.Drink;

namespace MilkTeaStore.Topping
{
    public class Peach : Topping
    {
        public Peach(DrinkBase drink) : base(drink)
        {
            ItemName = "Peach";
            ItemPrice = 4;
        }
    }
}