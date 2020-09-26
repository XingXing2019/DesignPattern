namespace MilkTeaStore.Drink
{
    public class FruitTea : DrinkBase
    {
        public FruitTea()
        {
            ItemName = "Fruit Tea";
            ItemPrice = 6;
        }
        
        public override string Desc => ItemName;
        public override int TotalCost => ItemPrice;
    }
}