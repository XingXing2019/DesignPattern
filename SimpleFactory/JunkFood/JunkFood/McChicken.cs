using System;

namespace JunkFood
{
    public class McChicken : IChicken
    {
        public void Eat()
        {
            Console.WriteLine("We are eating McChicken");
        }
    }
}