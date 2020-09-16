using System;

namespace JunkFood
{
    public class KFC : IStore
    {
        public IChips GetChips()
        {
            Console.WriteLine("KFC produce chips");
            return new KfcChips();
        }

        public IChicken GetChicken()
        {
            Console.WriteLine("KFC produce Orleans chicken");
            return new OrleansChicken();
        }
    }
}