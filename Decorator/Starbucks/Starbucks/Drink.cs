namespace Starbucks
{
    public abstract class Drink
    {
        public abstract string Description { get; }
        public abstract double Cost { get; }

        protected string ItemName;
        protected double ItemCost;

        protected abstract double GetCost();
        protected abstract string GetDescription();
    }
}