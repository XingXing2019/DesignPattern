using System;

namespace JunkFood
{
    public class OrleansChicken : IChicken
    {
        public void Eat()
        {
            Console.WriteLine("We are eating Orleans chicken");
        }
    }
}