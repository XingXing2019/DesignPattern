namespace MilkTeaStore.Drink
{
    public class MilkTea : DrinkBase
    {
        public MilkTea()
        {
            ItemName = "Milk Tea";
            ItemPrice = 8;
        }
        public override string Desc => ItemName;
        public override int TotalCost => ItemPrice;
    }
}