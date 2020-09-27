namespace Starbucks.Decorator
{
    public abstract class Decorator : Drink
    {
        private readonly Drink _drink;

        protected Decorator(Drink drink)
        {
            _drink = drink;
        }

        public override string Description => GetDescription();
        public override double Cost => GetCost();

        protected override double GetCost()
        {
            return  _drink.Cost + ItemCost;
        }

        protected override string GetDescription()
        {
            return $"{_drink.Description} + {ItemName}";
        }
    }
}