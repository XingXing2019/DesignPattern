using System;
using MilkTeaStore.Drink;
using MilkTeaStore.Topping;

namespace MilkTeaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinkBase milkTea = new MilkTea();
            milkTea = new Pearl(milkTea);
            milkTea = new Pudding(milkTea);
            Console.WriteLine($"Desc: {milkTea.Desc}");
            Console.WriteLine($"Total Cost: {milkTea.TotalCost}");

            DrinkBase fruitTea = new FruitTea();
            fruitTea = new Apple(fruitTea);
            fruitTea = new Peach(fruitTea);
            Console.WriteLine($"Desc: {fruitTea.Desc}");
            Console.WriteLine($"Total Cost: {fruitTea.TotalCost}");
        }
    }
}
