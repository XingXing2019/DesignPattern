namespace Starbucks.Decorator
{
    public class Milk : Decorator
    {
        public Milk(Drink drink) : base(drink)
        {
            ItemName = "Milk";
            ItemCost = 1.5;
        }
    }
}