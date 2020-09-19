using System;
using Mobile.Parts;

namespace Mobile
{
    public class Mobile
    {
        public Cpu Cpu { get; set; }
        public Memory Memory { get; set; }
        public Screen Screen { get; set; }

        public void Show()
        {
            Console.WriteLine("Mobile Configuration:");
            Console.WriteLine($"CPU: {Cpu?.Type}");
            Console.WriteLine($"Memory: {Memory?.Type}");
            Console.WriteLine($"Screen: {Screen?.Type}");
        }
    }
}