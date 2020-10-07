using HouseBuilder.House;
using HouseBuilder.Parts;

namespace HouseBuilder.Builder
{
    public class ApartmentBuilder : AbstractBuilder
    {
        private Wall _wall;
        private Roof _roof;
        protected override void BuildWall()
        {
            _wall = new Wall {Type = "Apartment Wall"};
        }

        protected override void BuildRoof()
        {
            _roof = new Roof {Type = "Apartment Roof"};
        }

        public override AbstractHouse Build()
        {
            BuildWall();
            BuildRoof();
            return new Apartment(_wall, _roof);
        }
    }
}