using MilkTea.Brand;
using MilkTea.Size;

namespace MilkTea.Drink
{
    public class Coffee : DrinkBase
    {
        public Coffee(BrandBase brand, SizeBase size) : base(brand, size)
        {
            Name = "Coffee";
            Cost = 5.0;
        }
    }
}