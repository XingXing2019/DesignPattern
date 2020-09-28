using MilkTea.Brand;
using MilkTea.Size;

namespace MilkTea.Drink
{
    public abstract class DrinkBase
    {
        private readonly BrandBase _brand;
        private readonly SizeBase _size;

        protected DrinkBase(BrandBase brand, SizeBase size)
        {
            _brand = brand;
            _size = size;
        }

        public string Name { get; set; }
        public double Cost { get; set; }

        public string Description => $"{Name} [{_brand.BrandName}], Size: {_size.Size}";
        public double TotalPrice => Cost * _brand.Ratio * _size.Ratio;
    }
}