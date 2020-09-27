namespace Starbucks.Decorator
{
    public class SoyMilk : Decorator
    {
        public SoyMilk(Drink drink) : base(drink)
        {
            ItemName = "Soy Milk";
            ItemCost = 2.0;
        }
    }
}