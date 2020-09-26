using MilkTeaStore.Drink;

namespace MilkTeaStore.Topping
{
    public abstract class Topping : DrinkBase
    {
        protected DrinkBase Drink;

        protected Topping(DrinkBase drink)
        {
            Drink = drink;
        }

        public override string Desc => $"{Drink.Desc} + {ItemName}";
        public override int TotalCost => Drink.TotalCost + ItemPrice;
    }
}