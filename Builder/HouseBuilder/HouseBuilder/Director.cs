using HouseBuilder.Builder;
using HouseBuilder.House;

namespace HouseBuilder
{
    public class Director
    {
        private AbstractBuilder _builder;

        public Director(AbstractBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(AbstractBuilder builder)
        {
            _builder = builder;
        }

        public AbstractHouse Build()
        {
            return _builder.Build();
        }
    }
}