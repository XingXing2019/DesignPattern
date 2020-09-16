using System;

namespace JunkFood
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new KFC();
            store.GetChips().Eat();
            store.GetChicken().Eat();
        }
    }
}
