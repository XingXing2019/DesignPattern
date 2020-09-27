namespace Starbucks.Coffee
{
    public abstract class Coffee : Drink
    {
        public override string Description => GetDescription();
        public override double Cost => GetCost();

        protected override double GetCost()
        {
            return ItemCost;
        }

        protected override string GetDescription()
        {
            return ItemName;
        }
    }
}