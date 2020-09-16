using System;

namespace JunkFood
{
    public class PizzaHut : IStore
    {
        public IChips GetChips()
        {
            Console.WriteLine("Pizza Hut produce chips");
            return new PizzaHutChips();
        }

        public IChicken GetChicken()
        {
            Console.WriteLine("Pizza Hut produce hand gun chicken");
            return new HandGunChicken();
        }
    }
}