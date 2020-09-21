using System;

namespace Resume
{
    [Serializable]
    public abstract class ResumeBase
    {
        public BasicInfo BasicInfo { get; set; }
        public WorkHistory WorkHistory { get; set; }

        public abstract void Display();
        public abstract ResumeBase DeepClone();
    }
}