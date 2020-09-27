namespace Starbucks.Decorator
{
    public class Chocolate : Decorator
    {
        public Chocolate(Drink drink) : base(drink)
        {
            ItemName = "Chocolate";
            ItemCost = 2.5;
        }
    }
}