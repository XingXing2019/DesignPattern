using System;
using Charger.Adapter;

namespace Charger
{
    public class Mobile
    {
        private readonly IAdapter _adapter;

        public Mobile(IAdapter adapter)
        {
            _adapter = adapter;
        }

        public void Charging()
        {
            var power = _adapter.Output();
            Console.WriteLine($"Charging Power: {power}");
        }
    }
}