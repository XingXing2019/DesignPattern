using System;
using MilkTea.Brand;
using MilkTea.Drink;
using MilkTea.Size;

namespace MilkTea
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinkBase milkTea = new FruitTea(new Coco(), new Small());
            Console.WriteLine($"Description: {milkTea.Description}");
            Console.WriteLine($"Total Cost: ${milkTea.TotalPrice:0.00}");
            Console.WriteLine("------------------------------------------");
            DrinkBase coffee = new Coffee(new StarBucks(), new Large());
            Console.WriteLine($"Description: {coffee.Description}");
            Console.WriteLine($"Total Cost: ${coffee.TotalPrice:0.00}");
        }
    }
}
