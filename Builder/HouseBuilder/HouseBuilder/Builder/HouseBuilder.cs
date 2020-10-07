using HouseBuilder.House;
using HouseBuilder.Parts;

namespace HouseBuilder.Builder
{
    public class HouseBuilder : AbstractBuilder
    {
        private Wall _wall;
        private Roof _roof;
        protected override void BuildWall()
        {
            _wall = new Wall{Type = "House Wall"};
        }

        protected override void BuildRoof()
        {
            _roof = new Roof {Type = "House Roof"};
        }

        public override AbstractHouse Build()
        {
            BuildWall();
            BuildRoof();
            return new House.House(_wall, _roof);
        }
    }
}