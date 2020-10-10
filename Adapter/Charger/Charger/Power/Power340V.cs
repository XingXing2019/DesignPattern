using System;

namespace Charger.Power
{
    public class Power340V : IPower
    {
        public int Output()
        {
            Console.WriteLine("Output 340 V");
            return 340;
        }
    }
}