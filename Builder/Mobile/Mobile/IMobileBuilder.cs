using System;
using Mobile.Parts;

namespace Mobile
{
    public interface IMobileBuilder
    {
        IMobileBuilder ConfigCpu(Action<Cpu> configCpuDelegate);
        IMobileBuilder ConfigMemory(Action<Memory> configMemoryDelegate);
        IMobileBuilder ConfigScreen(Action<Screen> configScreenDelegate);
        Mobile BuildMobile();
    }
}