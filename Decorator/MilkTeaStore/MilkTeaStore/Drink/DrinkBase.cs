namespace MilkTeaStore.Drink
{
    public abstract class DrinkBase
    {
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }

        public abstract string Desc { get;}
        public abstract int TotalCost { get; }
    }
}