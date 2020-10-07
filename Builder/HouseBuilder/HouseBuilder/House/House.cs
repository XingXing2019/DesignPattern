using System;
using HouseBuilder.Parts;

namespace HouseBuilder.House
{
    public class House : AbstractHouse
    {
        public House(Wall wall, Roof roof) : base(wall, roof) { }
    }
}