using System;
using Charger.Power;

namespace Charger.Adapter
{
    public class Adapter : IAdapter
    {
        private readonly IPower _power;

        public Adapter(IPower power)
        {
            _power = power;
        }

        public int Output()
        {
            var src = _power.Output();
            Console.WriteLine($"Source Power: {src}V");
            return 5;
        }
    }
}