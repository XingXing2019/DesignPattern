using HouseBuilder.House;

namespace HouseBuilder.Builder
{
    public abstract class AbstractBuilder
    {
        protected abstract void BuildWall();
        protected abstract void BuildRoof();
        public abstract AbstractHouse Build();
    }
}