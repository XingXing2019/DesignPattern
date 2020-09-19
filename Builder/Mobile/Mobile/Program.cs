using System;

namespace Mobile
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobileBuilder = new MobileBuilder();
            var mobile = mobileBuilder
                .ConfigCpu(cpu => cpu.Type = "8 Core")
                .ConfigMemory(memory => memory.Type = "32G")
                .ConfigScreen(screen => screen.Type = "10 inch")
                .BuildMobile();

            mobile.Show();
        }
    }
}
