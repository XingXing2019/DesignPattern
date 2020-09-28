using MilkTea.Brand;
using MilkTea.Size;

namespace MilkTea.Drink
{
    public class FruitTea : DrinkBase
    {
        public FruitTea(BrandBase brand, SizeBase size) : base(brand, size)
        {
            Name = "Fruit Tea";
            Cost = 6.0;
        }
    }
}