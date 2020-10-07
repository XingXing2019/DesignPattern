using System;
using HouseBuilder.Parts;

namespace HouseBuilder.House
{
    public class Apartment : AbstractHouse
    {
        public Apartment(Wall wall, Roof roof) : base(wall, roof) { }
    }
}