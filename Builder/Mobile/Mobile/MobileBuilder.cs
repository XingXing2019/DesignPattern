using System;
using Mobile.Parts;

namespace Mobile
{
    public class MobileBuilder : IMobileBuilder
    {
        private Cpu _cpu;
        private Memory _memory;
        private Screen _screen;
        private Mobile _mobile;

        public IMobileBuilder ConfigCpu(Action<Cpu> configCpuDelegate)
        {
            _cpu = new Cpu();
            configCpuDelegate?.Invoke(_cpu);
            return this;
        }

        public IMobileBuilder ConfigMemory(Action<Memory> configMemoryDelegate)
        {
            _memory = new Memory();
            configMemoryDelegate?.Invoke(_memory);
            return this;
        }

        public IMobileBuilder ConfigScreen(Action<Screen> configScreenDelegate)
        {
            _screen = new Screen();
            configScreenDelegate?.Invoke(_screen);
            return this;
        }

        public Mobile BuildMobile()
        {
            return new Mobile
            {
                Cpu = _cpu ?? new Cpu {Type = "4 Core"},
                Memory = _memory ?? new Memory {Type = "8G"},
                Screen = _screen ?? new Screen {Type = "7 inch"},
            };
        }
    }
}