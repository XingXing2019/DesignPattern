using System;
using Starbucks.Coffee;
using Starbucks.Decorator;

namespace Starbucks
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink order = new FlatWhite();
            Console.WriteLine($"Description: {order.Description}");
            Console.WriteLine($"Cost: {order.Cost}");
            Console.WriteLine("----------------------------------");

            order = new Milk(order);
            Console.WriteLine($"Description: {order.Description}");
            Console.WriteLine($"Cost: {order.Cost}");
            Console.WriteLine("----------------------------------");

            order = new Chocolate(order);
            Console.WriteLine($"Description: {order.Description}");
            Console.WriteLine($"Cost: {order.Cost}");
            Console.WriteLine("----------------------------------");

            order = new SoyMilk(order);
            Console.WriteLine($"Description: {order.Description}");
            Console.WriteLine($"Cost: {order.Cost}");
        }
    }
}
