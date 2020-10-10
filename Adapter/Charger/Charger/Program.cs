using System;
using Charger.Power;

namespace Charger
{
    class Program
    {
        static void Main(string[] args)
        {
            var powerSource = new Power340V();
            var adapter = new Adapter.Adapter(powerSource);
            var mobile = new Mobile(adapter);
            mobile.Charging();
        }
    }
}
