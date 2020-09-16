using System;

namespace JunkFood
{
    public class McDonald : IStore
    {
        public IChips GetChips()
        {
            Console.WriteLine("McDonald produce chips");
            return new McDonaldChips();
        }

        public IChicken GetChicken()
        {
            Console.WriteLine("McDonald produce McChicken");
            return new McChicken();
        }
    }
}