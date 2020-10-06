using System;

namespace Sheep
{
    [Serializable]
    public abstract class SheepBase
    {
        public BasicInfo BasicInfo { get; set; }
        public abstract void Display();
        public abstract SheepBase DeepClone();
    }
}