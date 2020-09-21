using System;

namespace SdReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer();
            var sd = new SdCard();
            computer.SetUsb(new SdReader(sd));
            computer.Display();
        }
    }
}
