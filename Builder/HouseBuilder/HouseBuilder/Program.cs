using System;
using HouseBuilder.Builder;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new Builder.ApartmentBuilder();
            var director = new Director(builder);
            director.Build().Show();
        }
    }
}
