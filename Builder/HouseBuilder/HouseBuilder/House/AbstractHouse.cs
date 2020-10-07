using System;
using HouseBuilder.Parts;

namespace HouseBuilder.House
{
    public abstract class AbstractHouse
    {
        protected Wall Wall { get; set; }
        protected Roof Roof { get; set; }

        protected AbstractHouse(Wall wall, Roof roof)
        {
            Wall = wall;
            Roof = roof;
        }

        public void Show()
        {
            Console.WriteLine($"Roof: {Roof.Type}");
            Console.WriteLine($"Wall: {Wall.Type}");
        }
    }
}