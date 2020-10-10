using System;

namespace Charger.Power
{
    public class Power220V : IPower
    {
        public int Output()
        {
            Console.WriteLine("Output 220 V");
            return 220;
        }
    }
}